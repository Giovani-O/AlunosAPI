﻿using AlunosAPI.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlunosAPI.Services
{
    public interface IAlunosService
    {
        Task<IEnumerable<Aluno>> GetAlunos();
        Task<Aluno> GetAluno(int id);
        Task<IEnumerable<Aluno>> GetAlunosByNome(string nome);
        Task CreateAluno(Aluno aluno);
        Task UpdateAluno(Aluno aluno);
        Task DeleteAluno(Aluno aluno);
    }
}
