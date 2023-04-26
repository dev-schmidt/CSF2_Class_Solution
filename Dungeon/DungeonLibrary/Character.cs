namespace DungeonLibrary
{
    public class Character
    {
        /*
            Create Fields and Properties for each of the following attributes.
            life - int
            name - string
            hitChance - int
            block - int
            maxLife - int
            
            INCLUDE a business rule that Life cannot be more than MaxLife. If it is, set it equal to MaxLife.
         */

        //funny
        //FIELDS
        private string _name;
        private int _maxLife;
        private int _life;
        private int _hitChance;
        private int _block;

        //people
        //PROPERTIES
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }

        public int Life
        {
            get { return _life; }
            set { _life = value; }
        }

        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }

        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }

        //collect
        //CONSTRUCTORS - Life = life; -> Life = maxLife.
        //no matter what, assign maxLife BEFORE Life.



        //monkeys
        //METHODS
    }
}