﻿using System;
using System.Collections.Generic;

namespace EduX_API.Domains
{
    public partial class AlunoTurma
    {
        public AlunoTurma()
        {
            ObjetivoAluno = new HashSet<ObjetivoAluno>();
        }

        public int IdAlunoTurma { get; set; }
        public string Matricula { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdTurma { get; set; }

        public virtual Turma IdTurmaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<ObjetivoAluno> ObjetivoAluno { get; set; }
    }
}
