using UnityEngine;

namespace Grow.BattleApplication {

    public class Factory {

        public RoleEntity CreateRoleEntity() {
            return new GameObject("role").AddComponent<RoleEntity>();
        }

        public FieldEntity CreateFieldEntity() {
            return new GameObject("field").AddComponent<FieldEntity>();
        }

    }

}