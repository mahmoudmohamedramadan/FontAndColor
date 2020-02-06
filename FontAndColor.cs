using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Watermark.Coordinate {
    public class FontAndColor {
	// when focuse in password textbox color changes from DarkGray (watermark color) to Black (writing color)
        public static void ChangeColorWhenFocused(TextBox txt) {
            if (txt.ForeColor == Color.DarkGray) {
	// here when txt's name is password and color is DarkGray we will turn DarkGray into Black and enable UseSystemPasswordChar to make it secret
                if (txt.Name == "txtPassword") {
                    txt.Text = "";
                    txt.UseSystemPasswordChar = true;
                    txt.ForeColor = Color.Black;
                } else {
		// but if txt's name was not from type password we wil turn DarkGray into Black without enable UseSystemPasswordChar
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                }
            }
        }
        // method ChangeColorWhenLeaved will raised in this code which exists in form code
       	private void txtFirstName_Enter(object sender, EventArgs e) {
            Coordinate.FontAndColor.ChangeColorWhenFocused(((TextBox)sender));
		  // Coordinate is folder
        }
	// here color of all textboxs will be DarkGray again 
        public static void ChangeColorWhenLeaved(TextBox txt) {
            if (txt.Text == "") {
                if (txt.Name == "txtFullName") {
                    txt.ForeColor = Color.DarkGray;
                    txt.Text = "Enter Full Name";
                } else if (txt.Name == "txtEmail") {
                    txt.ForeColor = Color.DarkGray;
                    txt.Text = "Enter Email";
                } else if (txt.Name == "txtUserName") {
                    txt.ForeColor = Color.DarkGray;
                    txt.Text = "Enter UserName";
                } else if (txt.Name == "txtPassword") {
                    txt.ForeColor = Color.DarkGray;
                    txt.UseSystemPasswordChar = false;
                    txt.Text = "Enter Password";
                } else if (txt.Name == "txtContact") {
                    txt.ForeColor = Color.DarkGray;
                    txt.Text = "Enter Phone Number";
                } else {
                    txt.ForeColor = Color.DarkGray;
                    txt.Text = "Enter Address";
                }
            }
        }
        // this method change color of text to DarkGray when btnClear pressed
        public static void ChangeColorToDarkGray(params TextBox[] txt) {
		// params accept array of object
            for (int i = 0; i < txt.Count() ; i++) {
                txt[i].ForeColor = Color.DarkGray;
            }
            txt[4].UseSystemPasswordChar = false;
        }
        // this method change color of watermark to black when Row Header of Data GridView Clicked
        public static void ChangeColorToBlack(params TextBox[] txt) {
            for (int i = 0; i < txt.Count() ; i++) {
                txt[i].ForeColor = Color.Black;
            }
            // this check if count of arguments is 7 will enable PasswordChar of txtPassword
            if (txt.Count() == 7)
                txt[4].UseSystemPasswordChar = true;
        }
    }
}