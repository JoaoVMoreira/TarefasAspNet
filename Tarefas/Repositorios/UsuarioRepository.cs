using Microsoft.EntityFrameworkCore;
using Tarefas.Data;
using Tarefas.Models;
using Tarefas.Repositorios.Interfaces;

namespace Tarefas.Repositorios
{
    public class UsuarioRepository : iUsuarioRepository
    {

        private readonly SistemContext _context;
        public UsuarioRepository(SistemContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
             await _context.Usuario.AddAsync(usuario);
            await _context.SaveChangesAsync();

            return usuario;
        }
        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarUsuarioPorId(id);
            if (id == null)
            {
                throw new Exception($"O usuário: {id} não foi localizado no banco de dados");
            }

            usuarioPorId.Name = usuario.Name;
            usuarioPorId.email = usuario.email;

            _context.Update(usuarioPorId);
            await _context.SaveChangesAsync();

            return usuarioPorId;


        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarUsuarioPorId(id);
            if (id == null)
            {
                throw new Exception($"O usuário: {id} não foi localizado no banco de dados");
            }

            _context.Remove(usuarioPorId);
            await _context.SaveChangesAsync();


            return true;
        }


        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _context.Usuario.ToListAsync();
        }

        public async Task<UsuarioModel> BuscarUsuarioPorId(int id)
        {
            return await _context.Usuario.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
