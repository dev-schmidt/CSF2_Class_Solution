namespace DungeonLibrary
{
    //abstract marks a class as "incomplete" it MUST be inherited somewhere to be used.
    //abstract classes cannot be created as an object using the "new()"
    public abstract class Character //Character's parent class is : Object
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
        private string _race;


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
            set 
            {
                if (value > MaxLife)
                    _life = MaxLife;
                else
                {
                    _life = value;
                }
            }
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

        public Character(string name, int hitChance, int block, int maxLife)
        {
            Name = name;
            MaxLife = maxLife;
            HitChance = hitChance;
            Life = maxLife;
            Block = block;
        }

        public Character() { }

        public override string ToString()
        {
            return $"{Name}\n" +
                $"Maximum Life Points: {MaxLife}" +
                $"Life Points: {Life}" +
                $"Chance to Hit: {HitChance}" +
                $"Block: {Block}";
        }

        //returns the in Block property, for now
        public virtual int CalcBlock()
        {
            return _block;
        }

        //returns the int HitChance property, for now
        public virtual int CalcHitChance()
        {
            return _hitChance;
        }

        //returns an int of 0, for now
        public abstract int CalcDamage();
        //an abstract method will have no functionality, no scope.
        //it makes override MANDATORY

        //monkeys
        //METHODS
    }
}