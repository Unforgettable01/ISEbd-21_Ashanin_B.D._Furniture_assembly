﻿using Furniture_assembly_BusinessLogic.BindingModels;
using Furniture_assembly_BusinessLogic.ViewModels;
using Furniture_assembly_ClientApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Furniture_assembly_ClientApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }
        public IActionResult Index()
        {
            if (Program.Client == null)
            {
                return Redirect("~/Home/Enter");
            }
            return
            View(APIClient.GetRequest<List<OrderViewModel>>($"api/main/getorders?clientId={Program.Client.Id}"));
        }
        [HttpGet]
        public IActionResult Privacy()
        {
            if (Program.Client == null)
            {
                return Redirect("~/Home/Enter");
            }
            return View(Program.Client);
        }
        [HttpPost]
        public void Privacy(string login, string password, string fio)
        {
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password)
            && !string.IsNullOrEmpty(fio))
            {
                //прописать запрос
                Program.Client.ClientFIO = fio;
                Program.Client.Email = login;
                Program.Client.Password = password;
                Response.Redirect("Index");
                return;
            }
            throw new Exception("Введите логин, пароль и ФИО");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore
        = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ??
            HttpContext.TraceIdentifier
            });
        }
        [HttpGet]
        public IActionResult Enter()
        {
            return View();
        }
        [HttpPost]
        public void Enter(string login, string password)
        {
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                Program.Client =
                APIClient.GetRequest<ClientViewModel>($"api/client/login?login={login}&password={password}");
if (Program.Client == null)
            {
                throw new Exception("Неверный логин/пароль");
            }
            Response.Redirect("Index");
            return;
        }
throw new Exception("Введите логин, пароль");
    }
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public void Register(string login, string password, string fio)
    {
        if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password)
        && !string.IsNullOrEmpty(fio))
        {
            APIClient.PostRequest("api/client/register", new
            ClientBindingModel
            {
                ClientFIO = fio,
                Email = login,
                Password = password
            });
            Response.Redirect("Enter");
            return;
        }
        throw new Exception("Введите логин, пароль и ФИО");
    }
    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Furniture =
        APIClient.GetRequest<List<FurnitureViewModel>>("api/main/getfurniturelist");
        return View();
    }
    [HttpPost]
    public void Create(int furniture, int count, decimal sum)
    {
        if (count == 0 || sum == 0)
        {
            return;
        }
        //прописать запрос
        Response.Redirect("Index");
    }
    [HttpPost]
    public decimal Calc(decimal count, int furniture)
    {
    FurnitureViewModel furn =
    APIClient.GetRequest<FurnitureViewModel>($"api/main/getfurniture?furnitureId={furniture}");
        return count * furn.Price;
    }
}

}
