using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> Cards = new List<string> {
        "A", "A", "A", "A",
        "2","2","2","2",
        "3","3","3","3",
        "4","4","4","4",
        "5","5","5","5",
        "6","6","6","6",
        "7","7","7","7",
        "8","8","8","8",
        "9","9","9","9",
        "10","10","10","10",
         "J","J","J","J",
         "Q","Q","Q","Q",
         "K","K","K","K",
        };

        List<string> PlayedCards = new List<string> {
        };

        List<string> PlayersCards = new List<string>
        {};

        List<string> DealersCards = new List<string>
        {};

        int playersHand = 0;
        int dealersHand = 0;
        int i = 0;
        int b = 1;
        int playersAces = 0;
        int dealersAces = 0;
        int gameStarted = 0;
        int drawnAmount = 0;

        //------------------------


            //The act of getting 21 causes the cards random index to think its out of bounds. Check draw cards and twenty one script.
        private string CardRandomizer()
        {
            //Getting a random value.
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, Cards.Count);
            //Indexing a random card.
            txttest.Text = randomIndex.ToString();
            string returnedCard = Cards[randomIndex];
            //Adding that card too another deck for later if the player restarts the game.
            PlayedCards.Add(returnedCard);
            //Removing that card from the deck.
            Cards.RemoveAt(randomIndex);
            //Returning that card.
            return (returnedCard);
        }

        public async void CardPuller(string name)
        {
            if (name == "Dealer" && drawnAmount == 0)
            {
                string card = CardRandomizer();
                DealersCards.Add(card);
                AceCheck(card, "Dealer");
                if (ValueCheck(card) == true)
                {
                    dealersHand = Convert.ToInt32(card);
                }
                else
                {
                    dealersHand = CardConvert(card);
                }
                txtDealer.Text = DealersCards[0].ToString();
                lblDealerCount.Text = dealersHand.ToString();
                CardCheck("Dealer");
            }
            else if(name == "Dealer")
            {
                string card = CardRandomizer();
                AceCheck(card, "Dealer");
                DealersCards.Add(card);
                while (b < DealersCards.Count)
                {
                    txtDealer.Text += "+";
                    txtDealer.Text += DealersCards[b].ToString();
                    b += 1;
                }

                if (ValueCheck(card) == true)
                {
                    dealersHand += Convert.ToInt32(card);
                }
                else
                {
                    dealersHand += CardConvert(card);
                }
                lblDealerCount.Text = dealersHand.ToString();
                CardCheck("Dealer");
                txttest2.Text = b.ToString();
            }
            if (name == "Player" && drawnAmount == 0)
            {
                while (2 > drawnAmount)
                {
                    string card = CardRandomizer();
                    if (drawnAmount == 1)
                    {
                        await Task.Delay(500);
                        card = CardRandomizer();
                    }
                    PlayersCards.Add(card);
                    if (drawnAmount == 1)
                    {
                        txtYourHand.Text += "+";
                    }

                    txtYourHand.Text += PlayersCards[i];
                    i++;

                    AceCheck(card, "Player");
                    if (ValueCheck(card) == true)
                    {
                        playersHand += Convert.ToInt32(card);
                    }
                    else
                    {
                        playersHand += CardConvert(card);
                    }
                    lblPlayerCount.Text = playersHand.ToString();
                    drawnAmount += 1;
                    CardCheck("Player");
                }
            }
            else if (name == "Player")
            {
                string card = CardRandomizer();
                AceCheck(card, "Player");
                PlayersCards.Add(card);
                while (i < PlayersCards.Count)
                {
                    txtYourHand.Text += "+";
                    txtYourHand.Text += PlayersCards[i].ToString();
                    i += 1;
                }

                if (ValueCheck(card) == true)
                {
                    playersHand += Convert.ToInt32(card);
                }
                else
                {
                    playersHand += CardConvert(card);
                }
                lblPlayerCount.Text = playersHand.ToString();
                CardCheck("Player");
            }

            
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (gameStarted > 0)
            {
                CardPuller("Player");
            }
            else
            {
                lblStart.Text = "Please press \"Start Game\"";
            }
            //if players hand goes over 21, but an ace is present in the code a ticker that counts how many aces they have will get minused
            //by 1 and their count will then get minused by 10.
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            Restart();
            gameStarted = 1;
            lblStart.Text = "";
            LblWait.Text = "Please wait while the dealer serves the cards.";
            await Task.Delay(500);
            CardPuller("Dealer");
            await Task.Delay(700);
            CardPuller("Player");
            LblWait.Text = "";
            CardCheck("Player");
        }

        public bool ValueCheck(string value)
        {
            int number = 0;
            bool success = int.TryParse(value, out number);
            if (success)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public int CardConvert(string card)
        {
            switch (card)
            {
                case "K":
                return 10;
                case "Q":
                return 10;
                case "J":
                return 10;
                case "A":
                return 11;
                default:
                return 100;
            }
        }

        public void AceCheck(string check, string person)
        {
            if(check == "A" && person == "Player")
            {
                playersAces += 1;
            }
            if (check == "A" && person == "Dealer")
            {
                dealersAces += 1;
            }

        }

        public void Restart()
        {
            drawnAmount = 0;
            gameStarted = 0;
            playersHand = 0;
            dealersHand = 0;
            i = 0;
            b = 1;
            playersAces = 0;
            dealersAces = 0;
            txtYourHand.Text = "";
            txtDealer.Text = "";
            lblLose.Text = "";
            lblDealerCount.Text = "";
            lblPlayerCount.Text = "";
            lblDealerOver.Text = "";
            lblYouWin.Text = "";
            lblDealerWin.Text = "";


            while (0 != PlayedCards.Count)
            {
                Cards.Add(PlayedCards[0]);
                PlayedCards.RemoveAt(0);
            }
            
            while(0 != PlayersCards.Count)
            {
                PlayersCards.RemoveAt(0);
            }

            while (0 != DealersCards.Count)
            {
                DealersCards.RemoveAt(0);
            }
            lblStart.Text = "Please press \"Start Game\"";
        }

        private async void btnHold_Click(object sender, EventArgs e)
        {
            bool flag = false;
            while (flag == false)
            {
                if (playersHand > dealersHand && dealersHand >= 16 && playersHand < 22)
                {
                    lblYouWin.Text = "Congratulations, you win!";
                    flag = true;
                    await Task.Delay(3000);
                    Restart();

                }
                else if (playersHand > dealersHand && dealersHand <= 16 && playersHand < 22)
                {
                    CardPuller("Dealer");
                    await Task.Delay(1000);
                }
                else if (playersHand < dealersHand && dealersHand < 22)
                {
                    lblDealerWin.Text = "Sorry, dealer wins!";
                    flag = true;
                    await Task.Delay(3000);
                    Restart();
                }
                else if(dealersHand > 22 && playersHand < 22)
                {
                    CardCheck("Dealer");
                    flag = true;
                }
                else if(dealersHand < 16 && playersHand == dealersHand)
                {
                    CardPuller("Dealer");
                    await Task.Delay(1000);
                }
                else if (dealersHand <= 16 && playersHand == dealersHand)
                {
                    lblTie.Text = "Tieeeeeeeeeeeeeee";
                    flag = true;
                    await Task.Delay(3000);
                    Restart();
                }
                else
                {
                    flag = true;
                }
            }
        }

        public async void CardCheck(string name)
        {
            if (21 < playersHand && playersAces == 0 && name == "Player")
            {
                lblLose.Text = "Over 21, Bust";
                await Task.Delay(3000);
                Restart();
            }
            else if (21 < playersHand && playersAces > 0 && name == "Player")
            {
                playersHand -= 10;
                lblPlayerCount.Text = playersHand.ToString();
                playersAces -= 1;
            }

            if (21 < dealersHand && dealersAces == 0 && name == "Dealer")
            {
                lblDealerOver.Text = "Dealer over 21, You win!";
                await Task.Delay(3000);
                Restart();
            }
            else if (21 < dealersHand && dealersAces > 0 && name == "Dealer")
            {
                dealersHand -= 10;
                lblDealerCount.Text = dealersHand.ToString();
            }
        }

        //playersHand += CardPuller();
        //await Task.Delay(500);
        //if use await make sure to put async behind void on button use.
        //Possible Ace solution
        //Make a type of branch if an ace is selected. So make two variables one with 1 and the other with +11
        //Then if the count on one goes over the other will replace it.
    }
}
