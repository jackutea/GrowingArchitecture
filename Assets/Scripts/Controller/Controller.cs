namespace Grow {

    public class Controller {

        Context ctx;
        Domain domain;

        public Controller() { 
            this.domain = new Domain();
        }

        public void Inject(Context ctx) {
            this.ctx = ctx;
        }

        public void GameEnter() {
            domain.SpawnRole();
            domain.SpawnField();
        }

        public void GameTick(float dt) {

        }

    }

}