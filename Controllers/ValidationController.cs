﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClientValidation.Models;
using System.IO; 

namespace ClientValidation.Controllers
{
    public class ValidationController : Controller
    {
        //
        // GET: /Validation/
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(Validation model, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                //bind the model attributes to send it to view//
                ViewBag.Name = model.Name;
                ViewBag.Phone = model.Phone;
                ViewBag.Email = model.Email;
                ViewBag.Gender = model.Gender;

                string _FileName = Path.GetFileName(upload.FileName);
                string _path = Path.Combine(Server.MapPath("~/Images"), _FileName);
                upload.SaveAs(_path);
                
                ViewBag.Message = "File Uploaded Successfully!!";
                //clear the model once data is submitted// 
                ModelState.Clear();
                //on click of submit, show the text message// 
                TempData["Success Message"] = "data saved successfully";

                return View();


                
            }
            return View(model); 
            
        }
        
	}
}