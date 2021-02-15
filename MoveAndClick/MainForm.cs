/*
 * Created by SharpDevelop.
 * User: KServ
 * Date: 15.02.2021
 * Time: 15:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MoveAndClick
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
	    public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
	    private const int MOUSEEVENTF_LEFTDOWN = 0x02;
	    private const int MOUSEEVENTF_LEFTUP = 0x04;
	    private const int MOUSEEVENTF_MOVE = 0x0001;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			Cursor.Position = new Point(SystemInformation.VirtualScreen.Width - 10, 10);
			
			uint X = (uint)Cursor.Position.X;
      		uint Y = (uint)Cursor.Position.Y;
      		mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
		}
	}
}