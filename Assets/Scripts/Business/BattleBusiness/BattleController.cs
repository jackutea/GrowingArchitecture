namespace Grow {

    public class BattleController {

        BattleContext context;
        RoleDomain roleDomain;
        FieldDomain fieldDomain;

        public BattleController() { 
            this.roleDomain = new RoleDomain();
            this.fieldDomain = new FieldDomain();
            this.context= new BattleContext();
        }

        public void Inject(BattleApp battleApp) {
            this.context.battleApp = battleApp;
        }

        public void GameEnter() {
            roleDomain.SpawnRole();
            fieldDomain.SpawnField();
        }

        public void GameTick(float dt) {

        }

    }

}