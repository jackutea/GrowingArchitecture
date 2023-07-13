namespace Grow {

    public class TownController {

        Context ctx;
        RoleDomain roleDomain;

        public TownController() { 
            this.roleDomain = new RoleDomain();
        }

        public void Inject(Context ctx) {
            this.ctx = ctx;
        }

        public void GameEnter() {
            roleDomain.SpawnRole();
        }

        public void GameTick(float dt) {

        }

    }

}