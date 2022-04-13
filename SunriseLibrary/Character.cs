using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunriseLibrary
{
    public class Character
    {
        private string _name;
        private int _hitChance;
        private int _block;
        private int _life;
        private int _maxLife;
        private PlayableCharacter _selectedCharacter;
        private Weapon _equippedWeapon;

        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }
        public PlayableCharacter SelectedCharacter { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }//End If
                else
                {
                    _life = MaxLife;
                }//End Else
            }
        }//End Life Prop

        public Character(string name, int hitChance, int block, int maxLife, int life, PlayableCharacter selectedCharacter, Weapon equippedWeapon)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = life;
            SelectedCharacter = selectedCharacter;
            EquippedWeapon = equippedWeapon;
        }//End FQCTOR

        public override string ToString()
        {
            string description = "";
            switch (SelectedCharacter)
            {
                case PlayableCharacter.TheRookie:
                    break;
                case PlayableCharacter.TheStudent:
                    break;
                case PlayableCharacter.TheAgent:
                    break;
                case PlayableCharacter.TheCaptain:
                    break;
            }//End Switch

            return string.Format("\n-=-=- {0} -=-=-\n" +
                "Life: {1} of {2}\n" +
                "Hit Chance: {3}%\n\n" +
                "Weapon:\n{4}\nBlock: {5}\nDescription: {6}\n",
                Name,
                Life,
                MaxLife,
                HitChance,
                EquippedWeapon,
                Block,
                description);
        }//End ToString()

    }//End Class
}//End Namespace
