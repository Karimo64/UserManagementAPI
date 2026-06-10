using UserManagementAPI.Models;

namespace UserManagementAPI.Services
{
    public class UserService
    {
        private readonly List<User> _users = new();
        private int _nextId = 1;

        // Obtener todos los usuarios
        public IEnumerable<User> GetAll() => _users;

        // Obtener usuario por ID
        public User? GetById(int id) => _users.FirstOrDefault(u => u.Id == id);

        // Crear usuario
        public User Create(User user)
        {
            user.Id = _nextId++;
            _users.Add(user);
            return user;
        }

        // Actualizar usuario
        public bool Update(int id, User updatedUser)
        {
            var existing = GetById(id);
            if (existing == null) return false;

            existing.Name = updatedUser.Name;
            existing.Email = updatedUser.Email;
            existing.Role = updatedUser.Role;

            return true;
        }

        // Eliminar usuario
        public bool Delete(int id)
        {
            var user = GetById(id);
            if (user == null) return false;

            _users.Remove(user);
            return true;
        }
    }
}
