namespace Grow {

    public class RoleDomain {

        BattleContext ctx;

        public RoleDomain() { }

        public void Inject(BattleContext ctx) {
            this.ctx = ctx;
        }

        public void SpawnRole() {

            var factory = ctx.factory;

            var role = factory.CreateRoleEntity();
            var roleRepo = ctx.roleRepository;
            roleRepo.AddRole(role);

        }

    }

}