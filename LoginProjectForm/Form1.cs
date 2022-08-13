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

namespace LoginProjectForm
{
    public partial class Form1 : Form
    {
        private IMongoClient client = new MongoClient(
            "mongodb+srv://admin-net:admin-net@cluster0.zxlfk2g.mongodb.net/?retryWrites=true&w=majority"
        );

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Database");
            var collection = database.GetCollection<Usuario>("usuarios");
            var filter = Builders<Usuario>.Filter.Eq("username", txt_Usuario.Text);
            var result = collection.Find(filter).ToList();
            // EL USUARIO ES "Saltos" (SIN COMILLAS)
            // LA CONTRASEÑA ES "password" (SIN COMILLAS)
            if (result.Count > 0)
            {
                if (result[0].Password == txt_Password.Text)
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
    }
}
