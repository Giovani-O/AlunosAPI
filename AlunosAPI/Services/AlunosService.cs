using AlunosAPI.Context;
using AlunosAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunosAPI.Services
{
    public class AlunosService : IAlunosService
    {
        private readonly AppDbContext _context;

        public AlunosService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Aluno>> GetAlunos()
        {
            try
            {
                return await _context.Alunos.ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<Aluno>> GetAlunosByNome(string nome)
        {
            try
            {
                IEnumerable<Aluno> alunos;

                if (!string.IsNullOrWhiteSpace(nome))
                    alunos = await _context.Alunos.Where(n => n.Nome.Contains(nome)).ToListAsync();
                else
                    alunos = await GetAlunos();

                return alunos;
            }
            catch
            {
                throw;
            }
        }

        public async Task<Aluno> GetAluno(int id)
        {
            try
            {
                return await _context.Alunos.FindAsync(id);
            }   
            catch
            {
                throw;
            }
        }

        public async Task CreateAluno(Aluno aluno)
        {
            try
            {
                _context.Alunos.Add(aluno);
                await _context.SaveChangesAsync();
            }            
            catch
            {
                throw;
            }
        }

        public async Task UpdateAluno(Aluno aluno)
        {
            try
            {
                _context.Entry(aluno).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task DeleteAluno(Aluno aluno)
        {
            try
            {
                _context.Alunos.Remove(aluno);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
