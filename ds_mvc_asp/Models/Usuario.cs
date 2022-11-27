﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ds_mvc_asp.Models
{
    public class Usuario
    {
        [Display (Name = "Username")]
        [Required (ErrorMessage = "O nome é obrigatório")]

        public string NomeUsuario { get; set;  }

        [Display (Name = "Email")]
        [RegularExpression (@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido")]

        public string Email { get; set; }

        [Display (Name = "Crie o seu login")]
        [RegularExpression (@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras e de 5 a 15 caracteres")]
        [Required (ErrorMessage = "Login obrigatório")]
        //[Remote ("LoginUnico", "usuario", ErrorMessage = "Login já cadastrado")]

        public string Login { get; set; }

        [Display (Name = "Crie sua senha")]
        [Required (ErrorMessage = "Senha obrigatória")]

        public string Senha { get; set; }

        [Display(Name = "Confirmar senha")]
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "A senha não corresponde")]
        public string Confsenha { get; set; }

    }
}