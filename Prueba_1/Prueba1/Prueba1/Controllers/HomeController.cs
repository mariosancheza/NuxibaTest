using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Prueba1.Models;

namespace Prueba1.Controllers
{
    public class HomeController : Controller
    {
        private Collection<User> getUsuarios()
        {
            Collection<User> usuarios;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://jsonplaceholder.typicode.com/users");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                usuarios = JsonConvert.DeserializeObject<Collection<User>>(json);
            }
            return usuarios;
        }

        private User getUsuarioById(int id)
        {
            //int id_temp = -1;
            Collection<User> usuarios = getUsuarios();
            User usuario = new User();
            usuario.id = id;
            /*for (int c = 0; c < usuarios.Count; c++)
            {
                if (usuarios.ElementAt(c).id == id)
                {
                    id_temp = c;
                    break;
                }
            }
            if (id_temp != -1)
            {
                return usuarios.ElementAt(id_temp);
            }
            else
            {
                return new User();
            }*/
            if (usuarios.Contains(usuario))
            {
                return usuarios.ElementAt(usuarios.IndexOf(usuario));
            }
            else
            {
                return new User();
            }
        }

        private Collection<ToDo_s> GetToDo_S(int idUser)
        {
            Collection<ToDo_s> tareas;
            string strRequest = "https://jsonplaceholder.typicode.com/users/" + idUser + "/todos";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@strRequest);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                tareas = JsonConvert.DeserializeObject<Collection<ToDo_s>>(json);
            }
            return tareas;
        }

        private Collection<Posts> GetPosts(int idUser)
        {
            Collection<Posts> publicaciones;
            string strRequest = "https://jsonplaceholder.typicode.com/users/" + idUser + "/posts";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@strRequest);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                publicaciones = JsonConvert.DeserializeObject<Collection<Posts>>(json);
            }
            return publicaciones;
        }



        public IActionResult Index()
        {
            return View(getUsuarios());
        }


        //GET HomeController/Detail/int
        public ActionResult Detail(int id)
        {
            User usuario = getUsuarioById(id);
            if (usuario.id == id)
            {
                return View(usuario);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Publicaciones()
        {
            int idUser = Int32.Parse(Request.Form["txtId"]);
            ViewBag.Nombre = Request.Form["txtName"];
            return View(GetPosts(idUser));
        }

        [HttpPost]
        public ActionResult TareasDe()
        {
            int idUser = Int32.Parse(Request.Form["txtId"]);
            ViewBag.Nombre = Request.Form["txtName"];
            ViewBag.IdUser = Request.Form["txtId"];
            return View(GetToDo_S(idUser));
        }


        public ActionResult Comments()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult FormularioCrearTarea()
        {
            ViewBag.Nombre = Request.Form["txtName"];
            ViewBag.IdUser = Request.Form["txtId"];
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearTarea(IFormCollection collection)
        {
            Dictionary<string, object> ToDo = new Dictionary<string, object>();
            string json;
            bool completed, successful = false;
            try
            {
                ToDo.Add("userId", collection["userId"].ToString());
                ToDo.Add("title", collection["title"].ToString());
                completed = Convert.ToBoolean(collection["completed"].ToString().Split(',')[0]);
                ToDo.Add("completed", completed);
                json = JsonConvert.SerializeObject(ToDo);
                successful = PostToServer(json);
            }
            catch (Exception ex)
            {
                Logs.WriteLog(ex.Message);
            }
            if (successful)
            {
                Logs.WriteLog("La tarea fue asignada correctamente");
            }
            else
            {
                Logs.WriteLog("Error al asignar la tarea");
            }
            return RedirectToAction("Index", "Home");
        }

        private bool PostToServer(string json)
        {
            string result="";
            bool successful = false;
            try
            {
                string strPost = "https://jsonplaceholder.typicode.com/posts";
                WebRequest requestPost = WebRequest.Create(strPost);
                requestPost.Method = "POST";
                requestPost.ContentType = "application/json";
                using (StreamWriter sw = new StreamWriter(requestPost.GetRequestStream()))
                {
                    sw.Write(json);
                    sw.Flush();
                    sw.Close();

                    var response = requestPost.GetResponse();
                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                    {
                        result = sr.ReadToEnd();
                    }
                    Logs.WriteLog(result);
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLog(ex.Message);
            }
            if(result.Contains("\"id\": 101"))
            {
                successful = true;
            }
            return successful;
        }






        public IActionResult About()
        {
            ViewData["Message"] = "Nuxiba Test DevJr";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
