//  
//  Main.cs
//  
//  Author:
//       Dan Silk <silkypantsdan@gmail.com>
// 
//  Copyright (c) 2011 Dan Silk
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
using System.Reflection;

namespace ECMGTK
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            
         
         AppDomain.CurrentDomain.AssemblyResolve += HandleAppDomainCurrentDomainAssemblyResolve;
            Application.Init ();
            MainWindow win = new MainWindow ();
            win.Show ();
            Application.Run ();
    	}

        static Assembly HandleAppDomainCurrentDomainAssemblyResolve (object sender, ResolveEventArgs args)
        {
        	Console.WriteLine(args.Name);
			
			return Assembly.Load(args.Name);
        }
	}
}
