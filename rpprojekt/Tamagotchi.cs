using System;

namespace rpprojekt
{
    public class Tamagotchi
    {
        public string Name;
        public int hlad;
        public int nalada;
        public int energie;
        public int vek;
        public bool zije;
        public bool spi;
        public int ActionCooldown;

        public Tamagotchi(string name)
        {
            reset(name);
        }

        public void reset(string name)
        {   
            Name = name.Trim();

            hlad = 20;
            nalada = 80;
            energie = 80;
            vek = 0;
            zije = true;
            spi = false;
            ActionCooldown = 0;
            kontrola();
        }

        public void Feed(int amount)
        {
            if (!zije || spi || ActionCooldown > 0)
            {
                return;
            }

            int jidlo = amount * 10;

            if (jidlo > hlad)
            {
                int prebytek = jidlo - hlad;
                hlad = 0;
                nalada -= prebytek;
                energie -= prebytek;
            }
            else
            {
                hlad -= jidlo;
                nalada += 3;
                energie += 1;
            }

            ActionCooldown = 1;
            kontrola();
        }

        public void hrat()
        {
            if (!zije || spi || ActionCooldown > 0)
            {
                return;
            }

            nalada += 10;
            energie -= 10;
            hlad += 6;
            ActionCooldown = 1;
            kontrola();
        }

        public void spat()
        {
            if (!zije || ActionCooldown > 0)
            {
                return;
            }

            spi = true;
            ActionCooldown = 1;
            kontrola();
        }

        public void Tick()
        {
            if (!zije)
            {
                return;
            }

            vek += 1;

            if (ActionCooldown > 0)
            {
                ActionCooldown -= 1;
            }

            if (spi)
            {
                energie += 14;
                hlad += 1;
                nalada += 1;

                if (energie >= 95)
                {
                    spi = false;
                }
            }
            else
            {
                hlad += 3;
                energie -= 2;
                nalada -= 1;

                if (hlad > 70)
                {
                    nalada -= 2;
                }
            }

            kontrola();
        }

        public string DejVekText()
        {
            int hodiny = vek / 60;
            int minuty = vek % 60;

            if (hodiny == 0)
                return minuty + " minut";
            else
                return hodiny + " hodin " + minuty + " minut";
        }

        private void kontrola()
        {
            if (hlad < 0)
                hlad = 0;

            if (hlad > 100)
                hlad = 100;

            if (nalada < 0)
                nalada = 0;

            if (nalada > 100)
                nalada = 100;

            if (energie < 0)
                energie = 0;

            if (energie > 100)
                energie = 100;

            if (hlad >= 100 || nalada <= 0 || energie <= 0)
                zije = false;

            if (zije == false)
                spi = false;
        }
    }
}