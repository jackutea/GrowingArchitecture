namespace Grow {

    public class Controller {

        Context ctx;
        RoleDomain roleDomain;
        FieldDomain fieldDomain;

        public Controller() { 
            this.roleDomain = new RoleDomain();
            this.fieldDomain = new FieldDomain();
        }

        public void Inject(Context ctx) {
            this.ctx = ctx;
        }

        public void GameEnter() {
            roleDomain.SpawnRole();
            fieldDomain.SpawnField();
        }

        public void GameTick(float dt) {

        }

    }

}