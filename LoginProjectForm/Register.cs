using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using System.Security.Cryptography;
using System.IO;
using MongoDB.Bson;

namespace LoginProjectForm
{
    public partial class Register : Form
    {
        private IMongoClient client = new MongoClient(
            "mongodb+srv://admin-net:admin-net@cluster0.zxlfk2g.mongodb.net/?retryWrites=true&w=majority"
        );

        public Register()
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

        private void btn_RegresarLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            if (txt_Password.Text == txt_RepPassword.Text)
            {
                IMongoDatabase db = client.GetDatabase("Database");
                IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(
                    "usuarios"
                );
                var filter = Builders<BsonDocument>.Filter.Eq("username", txt_Usuario.Text);
                var result = collection.Find(filter).ToList();
                if (result.Count == 0)
                {
                    BsonDocument document = new BsonDocument
                    {
                        { "name", txt_Nombre.Text },
                        { "username", txt_Usuario.Text },
                        { "password", Encrypt(txt_Password.Text) },
                    };
                    collection.InsertOne(document);
                    MessageBox.Show("Usuario registrado exitosamente");
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("El usuario ya existe");
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }
    }
}
