namespace Grow {

    public class BattleContext {
        
        public RoleRepository roleRepository;
        public FieldRepository fieldRepository;
        
        public Factory factory;

        public BattleContext() {
            roleRepository = new RoleRepository();
            fieldRepository = new FieldRepository();
            factory = new Factory();
        }

    }
}