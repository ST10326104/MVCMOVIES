﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCMovies.Controllers;


public class HelloWorldController : Controller
{
    //
    // GET: /HelloWorld/
    public IActionResult index()
    {
        return View();
    }

    //
    // GET: /HelloWorld/Welcome/
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}

