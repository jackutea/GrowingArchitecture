namespace Grow {

    public class FieldDomain {

        Context ctx;

        public FieldDomain() { }

        public void Inject(Context ctx) {
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