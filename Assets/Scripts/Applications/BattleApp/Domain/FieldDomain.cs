namespace Grow {

    public class FieldDomain {

        BattleContext ctx;

        public FieldDomain() { }

        public void Inject(BattleContext ctx) {
            this.ctx = ctx;
        }

        public void SpawnField() {

            var factory = ctx.factory;

            var field = factory.CreateFieldEntity();
            var fieldRepo = ctx.fieldRepository;
            fieldRepo.SetField(field);
        }

    }

}