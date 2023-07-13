using System.Collections.Generic;

namespace Grow {

    public class RoleRepository {

        Dictionary<int, RoleEntity> allRole;

        public void AddRole(RoleEntity role) {

        }

        public void RemoveRole() {}

        public bool TryGetRole(out RoleEntity role) {
            role = null;
            return true;
        }

    }
}