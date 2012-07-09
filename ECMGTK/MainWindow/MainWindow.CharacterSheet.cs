﻿//  
//  MainWindow.CharacterSheet.cs
//  
//  Author:
//       Dan Silk <silkypantsdan@gmail.com>
// 
//  Copyright (c) 2012 Dan Silk
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using Gtk;
using System.Collections.Generic;

public partial class MainWindow : Gtk.Window
{
    static int SkillNameColumn = 0;
    static int SkillRankColumn = 1;
    static int SkillCurrSPColumn = 2;
    static int SkillNextSPColumn = 3;
    static int SkillLevelColumn = 4;
    static int SkillTimeToNextColumn = 5;
    static int SkillLearntColumn = 6;
    static int SkillIdColumn = 7;
    static int SkillLevlSPColumn = 8;
    static int SkillIsHeadingColumn = 9;

    ListStore charAttributeStore = new ListStore(typeof(Gdk.Pixbuf), typeof(string));
    TreeStore charSkillStore = new TreeStore(typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(double), typeof(bool), typeof(long), typeof(int), typeof(bool));
    TreeStore certStore = new TreeStore(typeof(string), typeof(int), typeof(long), typeof(bool), typeof(bool)); // Name, Grade, ID, IsCert, IsVisible
    TreeStore assetStore = new TreeStore(typeof(string), typeof(long), typeof(bool)); // Name, ID, IsHeading

    TreeModelFilter skillsFilter = null;
    TreeModelFilter certFilter = null;
    TreeModelFilter assetFilter = null;

    public void SetupCharacterTrees()
    {
        charSkillStore.Clear();

        ECM.ItemDatabase.LoadSkills(charSkillStore);

        skillsFilter = new TreeModelFilter(charSkillStore, null);
        skillsFilter.VisibleFunc = new TreeModelFilterVisibleFunc(HandleCharSkillsFilter);

        TreeModelSort skillsSorted = new TreeModelSort(skillsFilter);
        skillsSorted.SetSortColumnId(SkillNameColumn, SortType.Ascending);

        trvSkills.Model = skillsSorted;

        Console.WriteLine("Skills Loaded");

        certStore.Clear();

        ECM.ItemDatabase.LoadCertificateTree(certStore);

        certFilter = new TreeModelFilter(certStore, null);
        certFilter.VisibleFunc = new TreeModelFilterVisibleFunc(HandleCharCertFilter);

        TreeModelSort sorted = new TreeModelSort(certFilter);
        sorted.SetSortColumnId(0, SortType.Ascending);

        trvCertificates.Model = sorted;

        Console.WriteLine("Certificates Loaded");


        assetFilter = new TreeModelFilter(assetStore, null);
        assetFilter.VisibleFunc = new TreeModelFilterVisibleFunc(HandleCharAssetFilter);

        sorted = new TreeModelSort(assetFilter);
        sorted.SetSortColumnId(0, SortType.Ascending);

        trvAssets.Model = sorted;
    }

    void ShowCharacterSheet(ECM.Character currentCharacter)
    {
        Console.WriteLine("****** Changing Character");

        // unhook models?
        trvAttributes.Model = null;

        trvSkills.FreezeChildNotify();
        trvCertificates.FreezeChildNotify();
        trvAssets.FreezeChildNotify();

        charAttributeStore.Clear();

        lblCharName.Markup = string.Format("<b>{0}</b>", currentCharacter.Name);

        if (currentCharacter.Portrait != null)
            imgCharPortrait.Pixbuf = EveApi.ImageApi.StreamToPixbuf(currentCharacter.Portrait).ScaleSimple(160, 160, Gdk.InterpType.Bilinear);
        else
            imgCharPortrait.Pixbuf = EveApi.ImageApi.StreamToPixbuf(ECM.Core.NoPortraitJPG).ScaleSimple(160, 160, Gdk.InterpType.Bilinear);

        lblCurrentLocation.Markup = string.Format("<b>{0}</b>", currentCharacter.LastKnownLocation);
        lblBackground.Markup = string.Format("<b>{0}</b>", currentCharacter.Background);
        lblSkillpoints.Markup = string.Format("<b>{0}</b>", currentCharacter.SkillPoints.ToString("#0,0"));
        lblCone.Markup = string.Format("<b>{0} ({1:0,0})</b>", currentCharacter.CloneName, currentCharacter.CloneSkillPoints);
        lblDoB.Markup = string.Format("<b>{0}</b>", currentCharacter.Birthday.ToString("dd.MM.yyyy HH:mm:ss"));
        lblSecStatus.Markup = string.Format("<b>{0}</b>", currentCharacter.SecurityStatus.ToString("#0.00"));
        lblActiveShip.Markup = string.Format("<b>{0}\n({1})</b>", currentCharacter.ShipName, currentCharacter.ShipTypeName);

        if (string.IsNullOrEmpty(currentCharacter.Corporation))
        {
            lblCorporation.Text = string.Empty;
            lblAlliance.Text = string.Empty;
        }
        else
        {
            lblCorporation.Markup = string.Format("<b>{0}</b>", currentCharacter.Corporation);

            if (string.IsNullOrEmpty(currentCharacter.Alliance))
            {
                lblAlliance.Text = string.Empty;
            }
            else
            {
                lblAlliance.Markup = string.Format("<b>{0}</b>", currentCharacter.Alliance);
            }
        }

        lblCorporation.Visible = !string.IsNullOrEmpty(lblCorporation.Text);
        lblAlliance.Visible = !string.IsNullOrEmpty(lblAlliance.Text);

        lblAllianceTag.Visible = lblAlliance.Visible;
        lblCorporationTag.Visible = lblCorporation.Visible;

        // Load Attributes
        int charisma = currentCharacter.Attributes.Charisma + currentCharacter.Implants.Charisma.Amount;
        int intelligence = currentCharacter.Attributes.Intelligence + currentCharacter.Implants.Intelligence.Amount;
        int memory = currentCharacter.Attributes.Memory + currentCharacter.Implants.Memory.Amount;
        int perception = currentCharacter.Attributes.Perception + currentCharacter.Implants.Perception.Amount;
        int willpower = currentCharacter.Attributes.Willpower + currentCharacter.Implants.Willpower.Amount;

        charAttributeStore.AppendValues(new Gdk.Pixbuf(null, "ECMGTK.Resources.Icons.IntelligenceBrain"), string.Format("INTELLIGENCE\n{0} points", intelligence));
        charAttributeStore.AppendValues(new Gdk.Pixbuf(null, "ECMGTK.Resources.Icons.PerceptionBrain"), string.Format("PERCEPTION\n{0} points", perception));
        charAttributeStore.AppendValues(new Gdk.Pixbuf(null, "ECMGTK.Resources.Icons.CharismaBrain"), string.Format("CHARISMA\n{0} points", charisma));
        charAttributeStore.AppendValues(new Gdk.Pixbuf(null, "ECMGTK.Resources.Icons.WillpowerBrain"), string.Format("WILLPOWER\n{0} points", willpower));
        charAttributeStore.AppendValues(new Gdk.Pixbuf(null, "ECMGTK.Resources.Icons.MemoryBrain"), string.Format("MEMORY\n{0} points", memory));

        trvAttributes.Model = charAttributeStore;

        // Traverse character skills tree and update the values
        TreeIter iter;
        charSkillStore.GetIterFirst(out iter);
        bool cont = true;

        while (cont)
        {
            // These are all the main categories
            if (charSkillStore.IterHasChild(iter))
            {
                charSkillStore.SetValue(iter, SkillLearntColumn, false);

                TreeIter child;
                charSkillStore.IterChildren(out child, iter);

                int numSkills = 0;
                int totalPoints = 0;
                bool showGroup = false;

                while (cont)
                {
                    long id = (long)charSkillStore.GetValue(child, SkillIdColumn);
                    ECM.EveSkill skill = ECM.ItemDatabase.Items[id] as ECM.EveSkill;
                    bool learnt = currentCharacter.Skills.ContainsKey(id);
                    int level = 0;
                    int points = 0;
                    double minsToNext = 0;

                    if (learnt)
                    {
                        level = currentCharacter.Skills[id].Level;
                        points = currentCharacter.Skills[id].Skillpoints;

                        showGroup = true;
                        numSkills++;
                    }

                    int pointsAtNext = skill.PointsAtLevel(level + 1);
                    int pointsAtCurr = skill.PointsAtLevel(level);

                    if (level < 5)
                    {
                        long diff = pointsAtNext - points;
                        double spPerMin = ECM.Core.CurrentCharacter.SkillpointsPerMinute(skill.PrimaryAttribute, skill.SecondaryAttribute);

                        minsToNext = diff / spPerMin;
                    }

                    charSkillStore.SetValue(child, SkillLevelColumn, level);
                    charSkillStore.SetValue(child, SkillTimeToNextColumn, minsToNext);

                    charSkillStore.SetValue(child, SkillLearntColumn, learnt);

                    charSkillStore.SetValue(child, SkillCurrSPColumn, points);
                    charSkillStore.SetValue(child, SkillNextSPColumn, pointsAtNext);
                    charSkillStore.SetValue(child, SkillLevlSPColumn, pointsAtCurr);

                    totalPoints += points;

                    cont = charSkillStore.IterNext(ref child);
                }

                charSkillStore.SetValue(iter, SkillLearntColumn, showGroup);
                charSkillStore.SetValue(iter, SkillCurrSPColumn, numSkills);
                charSkillStore.SetValue(iter, SkillNextSPColumn, totalPoints);
            }

            cont = charSkillStore.IterNext(ref iter);
        } 
        
        certStore.GetIterFirst(out iter);
        cont = true;

        while (cont)
        {
            // These are all the main categories
            if (certStore.IterHasChild(iter))
            {
                TreeIter child;
                certStore.IterChildren(out child, iter);

                bool showGroup = false;

                while (cont)
                {
                    long id = (long)certStore.GetValue(child, 2);

                    bool learnt = false;

                    foreach (EveApi.CharacterCertificates cert in currentCharacter.Certificates)
                    {
                        if (cert.ID == id) learnt = true;
                    }

                    if (learnt)
                    {
                        showGroup = true;

                        // Remove any prerequisite certificates
                        ECM.EveCertificate cert = ECM.ItemDatabase.Certificates[id];

                        foreach (ECM.EveCertificateRequirement req in cert.Requirements)
                        {
                            if(req.RequirementIsSkill == false)
                            {
                                ECM.EveCertificate reqCert = ECM.ItemDatabase.Certificates[req.RequirementID];
                                TreeIter reqIter;

                                if (certStore.GetIter(out reqIter, reqCert.TreeReference.Path))
                                {
                                    certStore.SetValue(reqIter, 4, false);
                                }
                            }
                        }
                    }

                    certStore.SetValue(child, 4, learnt);

                    cont = certStore.IterNext(ref child);
                }

                certStore.SetValue(iter, 4, showGroup);
            }

            cont = certStore.IterNext(ref iter);
        }

        assetStore.Clear();

        foreach (long locationID in currentCharacter.Assets.Keys)
        {
            ECM.EveStation station = ECM.MapDatabase.Stations[locationID];
            List<EveApi.AssetListInfo> locAssets = currentCharacter.Assets[locationID];
            string locHeader = string.Format("{0} - {1} items", station.Name, locAssets.Count);

            TreeIter locationNode = assetStore.AppendValues(locHeader, locationID, true);

            foreach (EveApi.AssetListInfo info in locAssets)
            {
                AppendAssetToNode(locationNode, info);
            }
        }

        skillsFilter.Refilter();
        certFilter.Refilter();
        assetFilter.Refilter();

        trvSkills.ThawChildNotify();
        trvCertificates.ThawChildNotify();
        trvAssets.ThawChildNotify();
    }

    private void AppendAssetToNode(TreeIter parentNode, EveApi.AssetListInfo info)
    {
        ECM.EveItem item = ECM.ItemDatabase.Items[info.TypeID];
        TreeIter thisNode = assetStore.AppendValues(parentNode, item.Name, info.TypeID, info.Contents.Count > 0);

        foreach (EveApi.ContentInfo contentInfo in info.Contents)
        {
            if (contentInfo is EveApi.AssetListInfo)
                AppendAssetToNode(thisNode, contentInfo as EveApi.AssetListInfo);
            else
            {
                item = ECM.ItemDatabase.Items[contentInfo.TypeID];
                assetStore.AppendValues(thisNode, item.Name, contentInfo.TypeID, false);
            }
        }
    }

    private bool HandleCharSkillsFilter(TreeModel model, TreeIter iter)
    {
        bool skillLearnt = (bool)charSkillStore.GetValue(iter, SkillLearntColumn);

        return skillLearnt;
    }

    private bool HandleCharCertFilter(TreeModel model, TreeIter iter)
    {
        bool certLearnt = (bool)model.GetValue(iter, 4);

        return certLearnt;
    }

    private bool HandleCharAssetFilter(TreeModel model, TreeIter iter)
    {
        return true;
    }

    protected void ShipClicked (object o, ButtonPressEventArgs args)
    {
        if(args.Event.Button == 1)
        {
            if(ECM.Core.CurrentCharacter != null)
            {
                SelectItemInMarket(ECM.ItemDatabase.Items[ECM.Core.CurrentCharacter.ShipTypeID]);
            }
        }
        else if(args.Event.Button == 3)
        {
            Menu m = new Menu();

            MenuItem viewItem = new MenuItem("View Item Details");
            MenuItem viewMarket = new MenuItem("View Market Details");
            MenuItem viewRender = new MenuItem("View Render");

            m.Add(viewItem);
            m.Add(viewMarket);
            m.Add(viewRender);

            viewItem.ButtonPressEvent += delegate(object sender, ButtonPressEventArgs e)
            {
                if (e.Event.Button == 1 && ECM.Core.CurrentCharacter != null)
                {
                    m_ViewDetails.ShowItemDetails(ECM.ItemDatabase.Items[ECM.Core.CurrentCharacter.ShipTypeID]);
                }
            };

            viewMarket.ButtonPressEvent += delegate(object sender, ButtonPressEventArgs e)
            {
                if (e.Event.Button == 1 && ECM.Core.CurrentCharacter != null)
                {
                    SelectItemInMarket(ECM.ItemDatabase.Items[ECM.Core.CurrentCharacter.ShipTypeID]);
                }
            };

            viewRender.ButtonPressEvent += delegate(object sender, ButtonPressEventArgs e)
            {
                if(e.Event.Button == 1 && ECM.Core.CurrentCharacter != null)
                {
                    m_ViewRender.ShowItemRender(ECM.ItemDatabase.Items[ECM.Core.CurrentCharacter.ShipTypeID]);
                }
            };

            m.ShowAll();
            m.Popup();
        }
    }

}
