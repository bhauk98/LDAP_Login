using System;
using System.Windows.Forms;
using System.Net;
using System.DirectoryServices;
using System.DirectoryServices.Protocols;
using System.Security.Permissions;
using System.Runtime.InteropServices;

namespace login
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        [DirectoryServicesPermission(SecurityAction.LinkDemand, Unrestricted = true)]
        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LdapDirectoryIdentifier ldi = new LdapDirectoryIdentifier("surgeserver", 389);//finds the server
                System.DirectoryServices.Protocols.LdapConnection ldapConnection =
                    new System.DirectoryServices.Protocols.LdapConnection(ldi);//connects to the server
                Console.WriteLine("Connection made");
                ldapConnection.AuthType = AuthType.Basic;
                ldapConnection.SessionOptions.ProtocolVersion = 3;
                NetworkCredential nc = new NetworkCredential(userName.Text,passWord.Text); 
                ldapConnection.Bind(nc);//checks the username and password
                Console.WriteLine("Conncetion succesful");
                MessageBox.Show("Connection Succesful");
                ldapConnection.Dispose();

            }
            catch (LdapException er) {
                Console.WriteLine("Connection Error" + er.Message);
                MessageBox.Show("Incorrect Credentials");
            }




        }
        public class IncorrectException : Exception
        {

        }
       
    }
}
