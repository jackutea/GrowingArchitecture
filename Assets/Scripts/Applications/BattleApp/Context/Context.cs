namespace Grow {

    public class Context {
        
        public RoleRepository roleRepository;
        public FieldRepository fieldRepository;
        
        public Factory factory;

        public Context() {
            roleRepository = new RoleRepository();
            fieldRepository = new FieldRepository();
            factory = new Factory();
        }

    }
}