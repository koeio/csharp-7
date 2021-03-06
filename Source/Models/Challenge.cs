﻿using System;
using System.Collections.Generic;

//Ajustei namespaces para ficar igual do teste
namespace Codenation.Challenge.Models
{
    public class Challenge
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public DateTime CreatedAt { get; set; }

        public List<Submission> Submissions { get; set; } //Propriedade de navegação
        public List<Acceleration> Accelerations { get; set; } //Propriedade de navegação
    }
}