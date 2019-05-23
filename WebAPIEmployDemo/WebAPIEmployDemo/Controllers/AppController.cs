using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using WebAPIEmployDemo.Models;

namespace WebAPIEmployDemo.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult Index()
        {
            IEnumerable<emp> list = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:50070/api/");
                var responseTask = client.GetAsync("emps");  
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                     var readTask = result.Content.ReadAsAsync<IList<emp>>();
                    readTask.Wait();
                    list = readTask.Result;
                }
                else
                {
                    list = Enumerable.Empty<emp>();
                    ModelState.AddModelError(string.Empty,
                        "Server error. Please contact administrator.");
                }
            }
            return View(list);

        }

        // GET: App/Details/5
        public ActionResult Details(int id)
        {
            emp emp1 = null;
            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new Uri("http://localhost:50070/api/");
                //HTTP GET
                var responseTask = client.GetAsync("emps?ID=" + id.ToString());
                // wait for task to complete
                responseTask.Wait();
                // retrieve the result
                var result = responseTask.Result;
                // check the status code for success
                if (result.IsSuccessStatusCode)
                {
                    // read the result
                    var readTask = result.Content.ReadAsAsync<emp>();
                    readTask.Wait();
                    // fill the person vairable created above with the returned result
                    emp1 = readTask.Result;
                }
            }
            return View(emp1);
        }

        // GET: App/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: App/Create
        [HttpPost]
        public ActionResult Create(emp emp1)
        {
            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new Uri("http://localhost:50070/api/");
                //HTTP POST
                var postTask = client.PostAsJsonAsync<emp>("emps",
                    emp1);
                // wait for task to complete
                postTask.Wait();
                // retrieve the result
                var result = postTask.Result;
                // check the status code for success
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(emp1);
        }

        // GET: App/Edit/5
        public ActionResult Edit(int id)
        {
            emp emp1 = null;

            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new Uri("http://localhost:50070/api/");
                //HTTP GET
                var responseTask = client.GetAsync("emps/" + id.ToString());
                // wait for task to complete
                responseTask.Wait();
                // retrieve the result
                var result = responseTask.Result;
                // check the status code for success
                if (result.IsSuccessStatusCode)
                {
                    // read the result
                    var readTask = result.Content.ReadAsAsync<emp>();
                    readTask.Wait();
                    // fill the person vairable created above with the returned result
                  emp1 = readTask.Result;
                }
            }
            return View(emp1);
        }

        // POST: App/Edit/5
        [HttpPost]
        public ActionResult Edit(emp obj)
        {
            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress =
                    new Uri("http://localhost:50070/api/");
                //HTTP POST
                var putTask = client.PutAsJsonAsync<emp>("emps", obj);
                // wait for task to complete
                putTask.Wait();
                // retrieve the result
                var result = putTask.Result;
                // check the status code for success
                if (result.IsSuccessStatusCode)
                {
                    // Return to Index
                    return RedirectToAction("Index");
                }
            }
            // Add model error
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            // send the view back with model error 
            return View(obj);
        }

        // GET: App/Delete/5
        public ActionResult Delete(int id)
        {
            emp emp1 = null;

            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new Uri("http://localhost:50070/api/");
                //HTTP GET
                var responseTask = client.GetAsync("emps/" + id.ToString());
                // wait for task to complete
                responseTask.Wait();
                // retrieve the result
                var result = responseTask.Result;
                // check the status code for success
                if (result.IsSuccessStatusCode)
                {
                    // read the result
                    var readTask = result.Content.ReadAsAsync<emp>();
                    readTask.Wait();
                    // fill the person vairable created above with the returned result
                    emp1 = readTask.Result;
                }
            }
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            // send the view back with model error 
            return View(emp1);
        }

        // POST: App/Delete/5
        [HttpPost]
        public ActionResult Delete(emp emp1)
        {
            int ID = emp1.Empno;

            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new Uri("http://localhost:50070/api/");
                //HTTP Delete
                var responseTask = client.DeleteAsync("emps/" + ID.ToString());
                // wait for task to complete
                responseTask.Wait();
                // retrieve the result
                var deleteTask = responseTask.Result;
                // check the status code for success
                if (deleteTask.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }
    }
}
