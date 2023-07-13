namespace Grow {

    public class Domain {

        Context ctx;

        public Domain() { }

        public void Inject(Context ctx) {
            this.ctx = ctx;
        }

        public void SpawnRole() {

            var factory = ctx.factory;

            var role = factory.CreateRoleEntity();
            var roleRepo = ctx.roleRepository;
            roleRepo.SetRole(role);

        }

        public void SpawnField() {

            var factory = ctx.factory;

            var field = factory.CreateFieldEntity();
            var fieldRepo = ctx.fieldRepository;
            fieldRepo.SetField(field);
        }

    }

}