﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Uno
{
    partial class SortedPlayerView : UserControl
    {

        private Player player;
        private bool moreDetail = false;
        private Game game;
        private Game.GamePlayer gamePlayer;




        public SortedPlayerView()
        {
            InitializeComponent();

            BackgroundImage = Properties.Resources.CardTableLight;


//            typeLabel.ForeColor = Color.FromArgb(126, 147, 73);
        }

        public void SetInfo(Player thePlayer, Game theGame)
        {
            game = theGame;
            player = thePlayer;
            gamePlayer = game.PlayersCards[player] as Game.GamePlayer;

            // Don't show the score label if basic scoring is used
            if (game.Options.ScoringSystem == GameOptions.ScoringSystems.Basic)
                scoreLabel.Visible = false;


            nameLabel.Text = player.Name;
            scoreLabel.Text = "Score: " + player.Score;

            //typeLabel.Text = Player.PlayerTypeToString(player.Type);
            typeBadge.Image = Player.PlayerTypeBadge(player.Type);

            turnsLabel.Text = gamePlayer.NumberOfTurns.ToString();
            cardsPickedUpLabel.Text = gamePlayer.NumberOfCardsPickedUp.ToString();
            cardsPlayedLabel.Text = gamePlayer.NumberOfCardsPlayed.ToString();
            
            ordinalLabel.Text = GetOrdinalStringForInt(player.Rank + 1);
            if(thePlayer.Team != 0)
            {
                TeamIndex.Text += " " + thePlayer.Team;
            }
        }

        

        /// <summary>
        /// Show or hide the extra detail
        /// </summary>
        /// <param name="detail"></param>
        public void SetMoreDetail(bool detail)
        {
            moreDetail = detail;

            if (moreDetail)
            {
                scoreLabel.Visible = true;
                
                Width = 370;
            }
            else
            {
                Width = 232;
                if (game.Options.ScoringSystem == GameOptions.ScoringSystems.Basic)
                    scoreLabel.Visible = false;
            }
        }




        /*
         * http://blogs.msdn.com/mhendersblog/archive/2005/10/12/480156.aspx
         * and http://www.eggheadcafe.com/software/aspnet/30750705/help-with-form-painting-p.aspx
         */

        private Bitmap renderBmp;

        public override Image BackgroundImage
        {
            set
            {
                Image baseImage = value;
                if (renderBmp != null)
                    renderBmp.Dispose();
                renderBmp = new Bitmap(this.Width, this.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                Graphics g = Graphics.FromImage(renderBmp);
                g.DrawImage(baseImage, 0, 0, Width, Height);
                g.Dispose();
            }
            get
            {
                return renderBmp;
            }
        }
        



        public static string GetOrdinalStringForInt(int rank)
        {
            string output;

            switch (rank)
            {
                case 1:
                    output = "First";
                    break;
                case 2:
                    output = "Second";
                    break;
                case 3:
                    output = "Third";
                    break;
                case 4:
                    output = "Forth";
                    break;
                // Don't need to include more than 4, as this game can only handle 4 players
                default:
                    output = "";
                    break;
            }

            return output;
        }
    }
}
