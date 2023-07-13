namespace Grow {

    public class RoleDomain {

        Context ctx;

        public RoleDomain() { }

        public void Inject(Context ctx) {
            this.ctx = ctx;
        }

        public void SpawnRole() {

            var factory = ctx.factory;

            var role = factory.CreateRoleEntity();
            var roleRepo = ctx.roleRepository;
            roleRepo.SetRole(role);

        }

    }

}