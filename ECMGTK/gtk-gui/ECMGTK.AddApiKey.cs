
// This file has been generated by the GUI designer. Do not modify.
namespace ECMGTK
{
	public partial class AddApiKey
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.Button btnCreateNewApiKey;
		private global::Gtk.Label GtkLabel2;
		private global::Gtk.Table table1;
		private global::Gtk.Label label3;
		private global::Gtk.Entry txtApiKeyID;
		private global::Gtk.Frame frame3;
		private global::Gtk.Alignment GtkAlignment;
		private global::Gtk.TextView txtVerificationCode;
		private global::Gtk.Label GtkLabel5;
		private global::Gtk.HButtonBox hbuttonbox2;
		private global::Gtk.Button btnRetrieveApi;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.Notebook ntbInfoAndLoading;
		private global::Gtk.VBox vbxKeyInfo;
		private global::Gtk.Frame frame8;
		private global::Gtk.Alignment GtkAlignment9;
		private global::Gtk.TreeView trvCharacters;
		private global::Gtk.Label GtkLabel10;
		private global::Gtk.Frame frame2;
		private global::Gtk.Alignment GtkAlignment3;
		private global::Gtk.Table table2;
		private global::Gtk.Image imgAccBalance;
		private global::Gtk.Image imgAccountStatus;
		private global::Gtk.Image imgAssetList;
		private global::Gtk.Image imgCalEvents;
		private global::Gtk.Image imgCharInfo;
		private global::Gtk.Image imgCharSheet;
		private global::Gtk.Image imgContactNotifications;
		private global::Gtk.Image imgContacts;
		private global::Gtk.Image imgContracts;
		private global::Gtk.Image imgFacWarStats;
		private global::Gtk.Image imgIndJobs;
		private global::Gtk.Image imgKillLog;
		private global::Gtk.Image imgMail;
		private global::Gtk.Image imgMarketOrders;
		private global::Gtk.Image imgMedals;
		private global::Gtk.Image ImgNotifications;
		private global::Gtk.Image imgReseach;
		private global::Gtk.Image imgSkillQueue;
		private global::Gtk.Image imgSkillTraining;
		private global::Gtk.Image imgStandings;
		private global::Gtk.Image imgWallJournal;
		private global::Gtk.Image imgWallTransactions;
		private global::Gtk.Label GtkLabel7;
		private global::Gtk.Label label2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Image imgSpinner;
		private global::Gtk.Label label1;
		private global::Gtk.Label label4;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button btnImport;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ECMGTK.AddApiKey
			this.Name = "ECMGTK.AddApiKey";
			this.Title = global::Mono.Unix.Catalog.GetString ("Add new Api Key");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.Internet.png");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.Modal = true;
			this.BorderWidth = ((uint)(3));
			this.Resizable = false;
			this.AllowGrow = false;
			this.DestroyWithParent = true;
			this.SkipTaskbarHint = true;
			// Internal child ECMGTK.AddApiKey.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(3));
			this.GtkAlignment2.TopPadding = ((uint)(3));
			this.GtkAlignment2.RightPadding = ((uint)(3));
			this.GtkAlignment2.BottomPadding = ((uint)(3));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.btnCreateNewApiKey = new global::Gtk.Button ();
			this.btnCreateNewApiKey.CanFocus = true;
			this.btnCreateNewApiKey.Name = "btnCreateNewApiKey";
			this.btnCreateNewApiKey.UseUnderline = true;
			this.btnCreateNewApiKey.Relief = ((global::Gtk.ReliefStyle)(2));
			this.btnCreateNewApiKey.Label = global::Mono.Unix.Catalog.GetString ("Click to generate API key with suggested features");
			this.GtkAlignment2.Add (this.btnCreateNewApiKey);
			this.frame1.Add (this.GtkAlignment2);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("Need a key?");
			this.GtkLabel2.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel2;
			this.vbox2.Add (this.frame1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frame1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Api Key ID:");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.txtApiKeyID = new global::Gtk.Entry ();
			this.txtApiKeyID.CanDefault = true;
			this.txtApiKeyID.CanFocus = true;
			this.txtApiKeyID.Name = "txtApiKeyID";
			this.txtApiKeyID.Text = global::Mono.Unix.Catalog.GetString ("1512");
			this.txtApiKeyID.IsEditable = true;
			this.txtApiKeyID.InvisibleChar = '●';
			this.table1.Add (this.txtApiKeyID);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.txtApiKeyID]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add (this.table1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.table1]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame3 = new global::Gtk.Frame ();
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(1));
			this.frame3.BorderWidth = ((uint)(3));
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.txtVerificationCode = new global::Gtk.TextView ();
			this.txtVerificationCode.Buffer.Text = "lE8EhrpxATliHxof1oiTOORFtty8jVqBdjkkFvscIYgD9mLHxK1m5z4ZvfsG0qyG";
			this.txtVerificationCode.HeightRequest = 30;
			this.txtVerificationCode.CanFocus = true;
			this.txtVerificationCode.Name = "txtVerificationCode";
			this.txtVerificationCode.AcceptsTab = false;
			this.txtVerificationCode.WrapMode = ((global::Gtk.WrapMode)(1));
			this.GtkAlignment.Add (this.txtVerificationCode);
			this.frame3.Add (this.GtkAlignment);
			this.GtkLabel5 = new global::Gtk.Label ();
			this.GtkLabel5.Name = "GtkLabel5";
			this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString ("Verification Code:");
			this.frame3.LabelWidget = this.GtkLabel5;
			this.vbox2.Add (this.frame3);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frame3]));
			w10.Position = 2;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbuttonbox2 = new global::Gtk.HButtonBox ();
			this.hbuttonbox2.Name = "hbuttonbox2";
			this.hbuttonbox2.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.btnRetrieveApi = new global::Gtk.Button ();
			this.btnRetrieveApi.CanFocus = true;
			this.btnRetrieveApi.Name = "btnRetrieveApi";
			this.btnRetrieveApi.UseUnderline = true;
			this.btnRetrieveApi.Label = global::Mono.Unix.Catalog.GetString ("Retrieve Key Details");
			this.hbuttonbox2.Add (this.btnRetrieveApi);
			global::Gtk.ButtonBox.ButtonBoxChild w11 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.btnRetrieveApi]));
			w11.Expand = false;
			w11.Fill = false;
			this.vbox2.Add (this.hbuttonbox2);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbuttonbox2]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hseparator1]));
			w13.Position = 4;
			w13.Expand = false;
			w13.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w14.Position = 0;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.ntbInfoAndLoading = new global::Gtk.Notebook ();
			this.ntbInfoAndLoading.CanFocus = true;
			this.ntbInfoAndLoading.Name = "ntbInfoAndLoading";
			this.ntbInfoAndLoading.CurrentPage = 0;
			this.ntbInfoAndLoading.ShowBorder = false;
			this.ntbInfoAndLoading.ShowTabs = false;
			// Container child ntbInfoAndLoading.Gtk.Notebook+NotebookChild
			this.vbxKeyInfo = new global::Gtk.VBox ();
			this.vbxKeyInfo.Name = "vbxKeyInfo";
			this.vbxKeyInfo.Spacing = 6;
			// Container child vbxKeyInfo.Gtk.Box+BoxChild
			this.frame8 = new global::Gtk.Frame ();
			this.frame8.Name = "frame8";
			// Container child frame8.Gtk.Container+ContainerChild
			this.GtkAlignment9 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment9.Name = "GtkAlignment9";
			this.GtkAlignment9.LeftPadding = ((uint)(3));
			this.GtkAlignment9.TopPadding = ((uint)(3));
			this.GtkAlignment9.RightPadding = ((uint)(3));
			this.GtkAlignment9.BottomPadding = ((uint)(3));
			// Container child GtkAlignment9.Gtk.Container+ContainerChild
			this.trvCharacters = new global::Gtk.TreeView ();
			this.trvCharacters.HeightRequest = 65;
			this.trvCharacters.CanFocus = true;
			this.trvCharacters.Name = "trvCharacters";
			this.trvCharacters.EnableSearch = false;
			this.trvCharacters.HeadersVisible = false;
			this.GtkAlignment9.Add (this.trvCharacters);
			this.frame8.Add (this.GtkAlignment9);
			this.GtkLabel10 = new global::Gtk.Label ();
			this.GtkLabel10.Name = "GtkLabel10";
			this.GtkLabel10.LabelProp = global::Mono.Unix.Catalog.GetString ("Characters");
			this.frame8.LabelWidget = this.GtkLabel10;
			this.vbxKeyInfo.Add (this.frame8);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbxKeyInfo [this.frame8]));
			w17.Position = 0;
			// Container child vbxKeyInfo.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(3));
			this.GtkAlignment3.TopPadding = ((uint)(3));
			this.GtkAlignment3.RightPadding = ((uint)(3));
			this.GtkAlignment3.BottomPadding = ((uint)(3));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.table2 = new global::Gtk.Table (((uint)(3)), ((uint)(8)), true);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			this.table2.BorderWidth = ((uint)(3));
			// Container child table2.Gtk.Table+TableChild
			this.imgAccBalance = new global::Gtk.Image ();
			this.imgAccBalance.TooltipMarkup = "Account Balance";
			this.imgAccBalance.Sensitive = false;
			this.imgAccBalance.Name = "imgAccBalance";
			this.imgAccBalance.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.Money.png");
			this.table2.Add (this.imgAccBalance);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgAccBalance]));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgAccountStatus = new global::Gtk.Image ();
			this.imgAccountStatus.TooltipMarkup = "Account Status";
			this.imgAccountStatus.Sensitive = false;
			this.imgAccountStatus.Name = "imgAccountStatus";
			this.imgAccountStatus.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.Plex.png");
			this.table2.Add (this.imgAccountStatus);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgAccountStatus]));
			w19.TopAttach = ((uint)(2));
			w19.BottomAttach = ((uint)(3));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgAssetList = new global::Gtk.Image ();
			this.imgAssetList.TooltipMarkup = "Asset List";
			this.imgAssetList.Sensitive = false;
			this.imgAssetList.Name = "imgAssetList";
			this.imgAssetList.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.Assets.png");
			this.table2.Add (this.imgAssetList);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgAssetList]));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgCalEvents = new global::Gtk.Image ();
			this.imgCalEvents.TooltipMarkup = "Calender Events";
			this.imgCalEvents.Sensitive = false;
			this.imgCalEvents.Name = "imgCalEvents";
			this.imgCalEvents.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.Calender.png");
			this.table2.Add (this.imgCalEvents);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgCalEvents]));
			w21.LeftAttach = ((uint)(2));
			w21.RightAttach = ((uint)(3));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgCharInfo = new global::Gtk.Image ();
			this.imgCharInfo.TooltipMarkup = "Character Info";
			this.imgCharInfo.Sensitive = false;
			this.imgCharInfo.Name = "imgCharInfo";
			this.imgCharInfo.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.CharInfo.png");
			this.table2.Add (this.imgCharInfo);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgCharInfo]));
			w22.TopAttach = ((uint)(2));
			w22.BottomAttach = ((uint)(3));
			w22.LeftAttach = ((uint)(3));
			w22.RightAttach = ((uint)(4));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgCharSheet = new global::Gtk.Image ();
			this.imgCharSheet.TooltipMarkup = "Character Sheet";
			this.imgCharSheet.Sensitive = false;
			this.imgCharSheet.Name = "imgCharSheet";
			this.imgCharSheet.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.CharSheet.png");
			this.table2.Add (this.imgCharSheet);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgCharSheet]));
			w23.LeftAttach = ((uint)(3));
			w23.RightAttach = ((uint)(4));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgContactNotifications = new global::Gtk.Image ();
			this.imgContactNotifications.TooltipMarkup = "Contact Notifications";
			this.imgContactNotifications.Sensitive = false;
			this.imgContactNotifications.Name = "imgContactNotifications";
			this.imgContactNotifications.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.ContactNotifications.png");
			this.table2.Add (this.imgContactNotifications);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgContactNotifications]));
			w24.TopAttach = ((uint)(2));
			w24.BottomAttach = ((uint)(3));
			w24.LeftAttach = ((uint)(5));
			w24.RightAttach = ((uint)(6));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgContacts = new global::Gtk.Image ();
			this.imgContacts.TooltipMarkup = "Contacts";
			this.imgContacts.Sensitive = false;
			this.imgContacts.Name = "imgContacts";
			this.imgContacts.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.Contacts.png");
			this.table2.Add (this.imgContacts);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgContacts]));
			w25.LeftAttach = ((uint)(4));
			w25.RightAttach = ((uint)(5));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgContracts = new global::Gtk.Image ();
			this.imgContracts.TooltipMarkup = "Contracts";
			this.imgContracts.Sensitive = false;
			this.imgContracts.Name = "imgContracts";
			this.imgContracts.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.Contracts.png");
			this.table2.Add (this.imgContracts);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgContracts]));
			w26.TopAttach = ((uint)(2));
			w26.BottomAttach = ((uint)(3));
			w26.LeftAttach = ((uint)(2));
			w26.RightAttach = ((uint)(3));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgFacWarStats = new global::Gtk.Image ();
			this.imgFacWarStats.TooltipMarkup = "Faction Warfare Stats";
			this.imgFacWarStats.Sensitive = false;
			this.imgFacWarStats.Name = "imgFacWarStats";
			this.imgFacWarStats.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.FacWarStats.png");
			this.table2.Add (this.imgFacWarStats);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgFacWarStats]));
			w27.LeftAttach = ((uint)(5));
			w27.RightAttach = ((uint)(6));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgIndJobs = new global::Gtk.Image ();
			this.imgIndJobs.TooltipMarkup = "Industry Jobs";
			this.imgIndJobs.Sensitive = false;
			this.imgIndJobs.Name = "imgIndJobs";
			this.imgIndJobs.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.Industry.png");
			this.table2.Add (this.imgIndJobs);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgIndJobs]));
			w28.LeftAttach = ((uint)(6));
			w28.RightAttach = ((uint)(7));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgKillLog = new global::Gtk.Image ();
			this.imgKillLog.TooltipMarkup = "Kill Logs";
			this.imgKillLog.Sensitive = false;
			this.imgKillLog.Name = "imgKillLog";
			this.imgKillLog.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.KillLogs.png");
			this.table2.Add (this.imgKillLog);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgKillLog]));
			w29.LeftAttach = ((uint)(7));
			w29.RightAttach = ((uint)(8));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgMail = new global::Gtk.Image ();
			this.imgMail.TooltipMarkup = "Mail";
			this.imgMail.Sensitive = false;
			this.imgMail.Name = "imgMail";
			this.imgMail.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.Mail.png");
			this.table2.Add (this.imgMail);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgMail]));
			w30.TopAttach = ((uint)(1));
			w30.BottomAttach = ((uint)(2));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgMarketOrders = new global::Gtk.Image ();
			this.imgMarketOrders.TooltipMarkup = "Market Orders";
			this.imgMarketOrders.Sensitive = false;
			this.imgMarketOrders.Name = "imgMarketOrders";
			this.imgMarketOrders.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.Market.png");
			this.table2.Add (this.imgMarketOrders);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgMarketOrders]));
			w31.TopAttach = ((uint)(1));
			w31.BottomAttach = ((uint)(2));
			w31.LeftAttach = ((uint)(1));
			w31.RightAttach = ((uint)(2));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgMedals = new global::Gtk.Image ();
			this.imgMedals.TooltipMarkup = "Medals";
			this.imgMedals.Sensitive = false;
			this.imgMedals.Name = "imgMedals";
			this.imgMedals.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.Medal.png");
			this.table2.Add (this.imgMedals);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgMedals]));
			w32.TopAttach = ((uint)(1));
			w32.BottomAttach = ((uint)(2));
			w32.LeftAttach = ((uint)(2));
			w32.RightAttach = ((uint)(3));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.ImgNotifications = new global::Gtk.Image ();
			this.ImgNotifications.TooltipMarkup = "Notifications";
			this.ImgNotifications.Sensitive = false;
			this.ImgNotifications.Name = "ImgNotifications";
			this.ImgNotifications.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.Notifications.png");
			this.table2.Add (this.ImgNotifications);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table2 [this.ImgNotifications]));
			w33.TopAttach = ((uint)(2));
			w33.BottomAttach = ((uint)(3));
			w33.LeftAttach = ((uint)(4));
			w33.RightAttach = ((uint)(5));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgReseach = new global::Gtk.Image ();
			this.imgReseach.TooltipMarkup = "Research";
			this.imgReseach.Sensitive = false;
			this.imgReseach.Name = "imgReseach";
			this.imgReseach.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.Research.png");
			this.table2.Add (this.imgReseach);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgReseach]));
			w34.TopAttach = ((uint)(1));
			w34.BottomAttach = ((uint)(2));
			w34.LeftAttach = ((uint)(3));
			w34.RightAttach = ((uint)(4));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgSkillQueue = new global::Gtk.Image ();
			this.imgSkillQueue.TooltipMarkup = "Skill Queue";
			this.imgSkillQueue.Sensitive = false;
			this.imgSkillQueue.Name = "imgSkillQueue";
			this.imgSkillQueue.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.SkillQueue.png");
			this.table2.Add (this.imgSkillQueue);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgSkillQueue]));
			w35.TopAttach = ((uint)(1));
			w35.BottomAttach = ((uint)(2));
			w35.LeftAttach = ((uint)(5));
			w35.RightAttach = ((uint)(6));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgSkillTraining = new global::Gtk.Image ();
			this.imgSkillTraining.TooltipMarkup = "Skill In Training";
			this.imgSkillTraining.Sensitive = false;
			this.imgSkillTraining.Name = "imgSkillTraining";
			this.imgSkillTraining.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.SkillTraining.png");
			this.table2.Add (this.imgSkillTraining);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgSkillTraining]));
			w36.TopAttach = ((uint)(1));
			w36.BottomAttach = ((uint)(2));
			w36.LeftAttach = ((uint)(4));
			w36.RightAttach = ((uint)(5));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgStandings = new global::Gtk.Image ();
			this.imgStandings.TooltipMarkup = "Standings";
			this.imgStandings.Sensitive = false;
			this.imgStandings.Name = "imgStandings";
			this.imgStandings.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.Standings.png");
			this.table2.Add (this.imgStandings);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgStandings]));
			w37.TopAttach = ((uint)(1));
			w37.BottomAttach = ((uint)(2));
			w37.LeftAttach = ((uint)(6));
			w37.RightAttach = ((uint)(7));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgWallJournal = new global::Gtk.Image ();
			this.imgWallJournal.TooltipMarkup = "Wallet Journal";
			this.imgWallJournal.Sensitive = false;
			this.imgWallJournal.Name = "imgWallJournal";
			this.imgWallJournal.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.Journal.png");
			this.table2.Add (this.imgWallJournal);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgWallJournal]));
			w38.TopAttach = ((uint)(1));
			w38.BottomAttach = ((uint)(2));
			w38.LeftAttach = ((uint)(7));
			w38.RightAttach = ((uint)(8));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.imgWallTransactions = new global::Gtk.Image ();
			this.imgWallTransactions.TooltipMarkup = "Wallet Transactions";
			this.imgWallTransactions.Sensitive = false;
			this.imgWallTransactions.Name = "imgWallTransactions";
			this.imgWallTransactions.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ECMGTK.Resources.Icons.WallTransactions.png");
			this.table2.Add (this.imgWallTransactions);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.table2 [this.imgWallTransactions]));
			w39.TopAttach = ((uint)(2));
			w39.BottomAttach = ((uint)(3));
			w39.XOptions = ((global::Gtk.AttachOptions)(4));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment3.Add (this.table2);
			this.frame2.Add (this.GtkAlignment3);
			this.GtkLabel7 = new global::Gtk.Label ();
			this.GtkLabel7.Name = "GtkLabel7";
			this.GtkLabel7.LabelProp = global::Mono.Unix.Catalog.GetString ("Key Allows:");
			this.GtkLabel7.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel7;
			this.vbxKeyInfo.Add (this.frame2);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbxKeyInfo [this.frame2]));
			w42.Position = 1;
			w42.Expand = false;
			w42.Fill = false;
			this.ntbInfoAndLoading.Add (this.vbxKeyInfo);
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("page1");
			this.ntbInfoAndLoading.SetTabLabel (this.vbxKeyInfo, this.label2);
			this.label2.ShowAll ();
			// Container child ntbInfoAndLoading.Gtk.Notebook+NotebookChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.imgSpinner = new global::Gtk.Image ();
			this.imgSpinner.WidthRequest = 32;
			this.imgSpinner.HeightRequest = 32;
			this.imgSpinner.Name = "imgSpinner";
			this.imgSpinner.Xalign = 1F;
			this.hbox1.Add (this.imgSpinner);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.imgSpinner]));
			w44.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Fetching data...");
			this.hbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
			w45.Position = 1;
			this.ntbInfoAndLoading.Add (this.hbox1);
			global::Gtk.Notebook.NotebookChild w46 = ((global::Gtk.Notebook.NotebookChild)(this.ntbInfoAndLoading [this.hbox1]));
			w46.Position = 1;
			// Notebook tab
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("page2");
			this.ntbInfoAndLoading.SetTabLabel (this.hbox1, this.label4);
			this.label4.ShowAll ();
			w1.Add (this.ntbInfoAndLoading);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(w1 [this.ntbInfoAndLoading]));
			w47.Position = 1;
			// Internal child ECMGTK.AddApiKey.ActionArea
			global::Gtk.HButtonBox w48 = this.ActionArea;
			w48.Name = "dialog1_ActionArea";
			w48.Spacing = 10;
			w48.BorderWidth = ((uint)(5));
			w48.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("Cancel");
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w49 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w48 [this.buttonCancel]));
			w49.Expand = false;
			w49.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.btnImport = new global::Gtk.Button ();
			this.btnImport.Sensitive = false;
			this.btnImport.CanFocus = true;
			this.btnImport.Name = "btnImport";
			this.btnImport.UseUnderline = true;
			this.btnImport.Label = global::Mono.Unix.Catalog.GetString ("Import");
			this.AddActionWidget (this.btnImport, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w50 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w48 [this.btnImport]));
			w50.Position = 1;
			w50.Expand = false;
			w50.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 339;
			this.DefaultHeight = 506;
			this.txtApiKeyID.HasDefault = true;
			this.Show ();
			this.btnCreateNewApiKey.Clicked += new global::System.EventHandler (this.NeedKeyClick);
			this.btnRetrieveApi.Clicked += new global::System.EventHandler (this.RetrieveApiInfo);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.CancelClicked);
			this.btnImport.Clicked += new global::System.EventHandler (this.ImportKey);
		}
	}
}
