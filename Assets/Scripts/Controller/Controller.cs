namespace Grow {

    public class Controller {

        Context ctx;

        public Controller() { }

        public void Inject(Context ctx) {
            this.ctx = ctx;
        }

        public void GameEnter() {

            var factory = ctx.factory;

            var role = factory.CreateRoleEntity();
            var roleRepo = ctx.roleRepository;
            roleRepo.SetRole(role);

            var field = factory.CreateFieldEntity();
            var fieldRepo = ctx.fieldRepository;
            fieldRepo.SetField(field);

        }

        public void GameTick(float dt) {

        }

    }

}