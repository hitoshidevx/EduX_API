﻿using System;
using System.Collections.Generic;

namespace EduX_API.Domains
{
    public partial class Turma
    {
        public Turma()
        {
            AlunoTurma = new HashSet<AlunoTurma>();
            ProfessorTurma = new HashSet<ProfessorTurma>();
        }

        public int IdTurma { get; set; }
        public string Descricao { get; set; }
        public int? IdCurso { get; set; }

        public virtual Instituicao IdCursoNavigation { get; set; }
        public virtual ICollection<AlunoTurma> AlunoTurma { get; set; }
        public virtual ICollection<ProfessorTurma> ProfessorTurma { get; set; }
    }
}
