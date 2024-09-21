using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BackOffice
{
    public partial class Form1 : Form
    {
        private Bdconexion dbManager = new Bdconexion();
        public Form1()
        {
            InitializeComponent();
            cargarLista();
            this.Load += new System.EventHandler(this.Form1_Load);
           


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarLista();

        }

        private void listaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGetPost_Click(object sender, EventArgs e)
        {

        }


        private void cargarLista(){
        
            listaUsuarios.Items.Clear();
            string query = "SELECT id, nombre FROM bdbandapp.cuenta"; // Selecciono solo ID y nombre

            using (var reader = dbManager.ExecuteSelect(query))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0); // Obtener ID
                        string nombre = reader.GetString(1); // Obtener nombre

                        // Agregar un elemento al ListBox en el formato que desees
                        listaUsuarios.Items.Add($"ID: {id}, Nombre: {nombre}");
                    }
                }
            }

        }
            private void listaUsuarios_DoubleClick(object sender, EventArgs e){
        
            if (listaUsuarios.SelectedItem != null)
            {
                // Extraer el ID del usuario seleccionado
                string selectedItem = listaUsuarios.SelectedItem.ToString();
                int idUsuario = int.Parse(selectedItem.Split(',')[0].Split(':')[1].Trim()); // Extrae el ID

                // Llamar al método para cargar los posts
                cargarPosts(idUsuario);
            }
        }



        private void listaPosts_DoubleClick(object sender, EventArgs e){
   
            if (listaPosts.SelectedItem != null)
            {
                string selectedItem = listaPosts.SelectedItem.ToString();
                int idPost = int.Parse(selectedItem.Split(',')[0].Split(':')[1].Trim());

                Console.WriteLine($"Doble clic en Post ID: {idPost}");

                cargarComentarios(idPost);
            }
            else
            {
                Console.WriteLine("No hay ningún post seleccionado.");
            }
        }

        private void cargarComentarios(int idPost)
        {
            listaComentarios.Items.Clear();
            Console.WriteLine($"Cargando comentarios para Post ID: {idPost}");

            string query = $"SELECT c.id_de_uploads, c.contenido FROM BDBandapp.comentario c WHERE c.id_de_post = {idPost}";

            using (var reader = dbManager.ExecuteSelect(query))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        int idComentario = reader.GetInt32(0); // id_de_uploads
                        string contenido = reader.GetString(1); // contenido

                        listaComentarios.Items.Add($"ID: {idComentario}, Contenido: {contenido}");
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron comentarios.");
                }
            }
        }



        private void cargarPosts(int idUsuario)
        {
            listaPosts.Items.Clear(); // Limpiar la lista de posts antes de cargar nuevos datos
            
            string query = $"SELECT id, tipo FROM bdbandapp.uploads WHERE id_de_cuenta = { idUsuario} AND tipo = 'post' AND activo = 1"; // Selecciona posts del usuario

            using (var reader = dbManager.ExecuteSelect(query))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        int idPost = reader.GetInt32(0); // Obtener ID del post
                        string descripcion = reader.GetString(1); // Obtener descripción del post

                        // Agregar un elemento a la lista de posts en el formato que desees
                        listaPosts.Items.Add($"ID: {idPost}, Descripción: {descripcion}");
                    }
                }
            }
        }


        private void btnEliminarPost_Click(object sender, EventArgs e)
        {
            // Verifica que haya un elemento seleccionado en la lista de posts
            if (listaPosts.SelectedItem != null)
            {
                // Obtiene el ID del post seleccionado
                string selectedItem = listaPosts.SelectedItem.ToString();
                int idPost = ExtractIdFromSelectedItem(selectedItem); // Método para extraer el ID

                // Llama al método para eliminar el post
                if (EliminarPost(idPost))
                {
                    MessageBox.Show("Post eliminado correctamente.");
                    cargarPosts(idPost); // Vuelve a cargar la lista de posts
                }
                else
                {
                    MessageBox.Show("Error al eliminar el post.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un post para eliminar.");
            }
        }

        private bool EliminarPost(int idPost)
        {
            // Desactivar el post
            string updatePostQuery = $"UPDATE BDBandapp.uploads SET activo = 0 WHERE id = {idPost}";

            // Desactivar los comentarios asociados al post
            string updateComentariosQuery = $@"
        UPDATE BDBandapp.uploads 
        SET activo = 0 
        WHERE id IN (
            SELECT id_de_uploads 
            FROM BDBandapp.comentario 
            WHERE id_de_post = {idPost}
        );";

            try
            {
                bool postUpdated = dbManager.ExecuteUpdate(updatePostQuery);
                bool comentariosUpdated = dbManager.ExecuteUpdate(updateComentariosQuery);

                return postUpdated && comentariosUpdated; // Retorna verdadero si ambas actualizaciones fueron exitosas
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al eliminar post o comentarios: " + ex.Message);
                return false;
            }
        }

        // Método para extraer el ID del post de la cadena seleccionada
        private int ExtractIdFromSelectedItem(string selectedItem)
        {
            string[] parts = selectedItem.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            string idPart = parts[0].Split(':')[1].Trim(); // Obtener la parte después de "ID: "
            return int.Parse(idPart);
        }




        private void btnEliminarComentarios_Click(object sender, EventArgs e)
        {
            listaComentarios.Items.RemoveAt(listaComentarios.SelectedIndex);
        }

        private void btnBuscaPost_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarUser_Click(object sender, EventArgs e)
        {

        }
        private void btnBuscaComentarios_Click(object sender, EventArgs e)
        {

        }
        private void fotoPost_Click(object sender, EventArgs e)
        {

        }

        private void listaPosts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
    

