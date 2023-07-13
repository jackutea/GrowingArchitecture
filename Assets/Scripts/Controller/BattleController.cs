namespace Grow {

    public class BattleController {

        Context ctx;
        RoleDomain roleDomain;
        FieldDomain fieldDomain;

        public BattleController() { 
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