using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginProjectForm.Models;
using MongoDB.Driver;
using System.Security.Cryptography;
using System.IO;

namespace LoginProjectForm
{
    public partial class Login : Form
    {
        private IMongoClient client = new MongoClient(
            "mongodb+srv://admin-net:admin-net@cluster0.zxlfk2g.mongodb.net/?retryWrites=true&w=majority"
        );

        public Login()
        {
            InitializeComponent();
        }

        static string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(
                    EncryptionKey,
                    new byte[]
                    {
                        0x49,
                        0x76,
                        0x61,
                        0x6e,
                        0x20,
                        0x4d,
                        0x65,
                        0x64,
                        0x76,
                        0x65,
                        0x64,
                        0x65,
                        0x76
                    }
                );
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (
                        CryptoStream cs = new CryptoStream(
                            ms,
                            encryptor.CreateEncryptor(),
                            CryptoStreamMode.Write
                        )
                    )
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Database");
            var collection = database.GetCollection<Usuario>("usuarios");
            var filter = Builders<Usuario>.Filter.Eq("username", txt_Usuario.Text);
            var result = collection.Find(filter).ToList();

            // EL USUARIO ES "AdminSaltos" (SIN COMILLAS)
            // LA CONTRASEÑA ES "password" (SIN COMILLAS)
            if (result.Count > 0)
            {
                if (result[0].Password == Encrypt(txt_Password.Text))
                {
                    MessageBox.Show("Bienvenido " + result[0].Name + " :)");
                    lbl_ErrorContraseña.Text = "";
                }
                else
                {
                    lbl_ErrorContraseña.Text = "Contraseña incorrecta";
                }
                lbl_ErrorUsuario.Text = "";
            }
            else
            {
                lbl_ErrorUsuario.Text = "Usuario no encontrado";
            }
        }

        private void btn_CrearCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
