using App5.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace App5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class announcement : Page
    {
        
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public announcement()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }

        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
           
        }

        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
           
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string[] names = { "Person 1", "Person 2", "Person 3", "Person 4", "Person 5", "Person 6", "Person 7 ", "Person 8", "Person 9", "Person 10", "Person 11", "Person 12", "Person 13", "Person 14", "Person 15", "Person 16", "Person 17", "Person 18", "Person 19", "Person 20", "Person 21", "Person 22", "Person 23", "Person 24", "Person 25", "Person 26", "Person 27", "Person 28", "Person 29", "Person 30", "Person 31" };
            // 30 people
            int[,] clas = new int[31, 10]; // 5 people and 10 slots (for a day)
            clas[0, 0] = 0; clas[0, 1] = 1; clas[0, 2] = 0; clas[0, 3] = 1; clas[0, 4] = 1; clas[0, 5] = 1; clas[0, 6] = 0; clas[0, 7] = 1; clas[0, 8] = 0; clas[0, 9] = 1; //Person1
            clas[1, 0] = 1; clas[1, 1] = 1; clas[1, 2] = 0; clas[1, 3] = 0; clas[1, 4] = 1; clas[1, 5] = 1; clas[1, 6] = 0; clas[1, 7] = 0; clas[1, 8] = 1; clas[1, 9] = 1; //Person2
            clas[2, 0] = 1; clas[2, 1] = 0; clas[2, 2] = 0; clas[2, 3] = 0; clas[2, 4] = 0; clas[2, 5] = 1; clas[2, 6] = 1; clas[2, 7] = 1; clas[2, 8] = 1; clas[2, 9] = 1; //Person3
            clas[3, 0] = 1; clas[3, 1] = 1; clas[3, 2] = 1; clas[3, 3] = 0; clas[3, 4] = 1; clas[3, 5] = 0; clas[3, 6] = 0; clas[3, 7] = 0; clas[3, 8] = 0; clas[3, 9] = 0; //Person4
            clas[4, 0] = 1; clas[4, 1] = 0; clas[4, 2] = 1; clas[4, 3] = 0; clas[4, 4] = 1; clas[4, 5] = 0; clas[4, 6] = 1; clas[4, 7] = 0; clas[4, 8] = 1; clas[4, 9] = 0; //Person5
            clas[5, 0] = 0; clas[5, 1] = 1; clas[5, 2] = 0; clas[5, 3] = 1; clas[5, 4] = 1; clas[5, 5] = 1; clas[5, 6] = 0; clas[5, 7] = 1; clas[5, 8] = 0; clas[5, 9] = 1; //Person6
            clas[6, 0] = 1; clas[6, 1] = 1; clas[6, 2] = 0; clas[6, 3] = 0; clas[6, 4] = 1; clas[6, 5] = 1; clas[6, 6] = 0; clas[6, 7] = 0; clas[6, 8] = 1; clas[6, 9] = 1; //Person7
            clas[7, 0] = 1; clas[7, 1] = 0; clas[7, 2] = 0; clas[7, 3] = 0; clas[7, 4] = 0; clas[7, 5] = 1; clas[7, 6] = 1; clas[7, 7] = 1; clas[7, 8] = 1; clas[7, 9] = 1; //Person8
            clas[8, 0] = 1; clas[8, 1] = 1; clas[8, 2] = 1; clas[8, 3] = 0; clas[8, 4] = 1; clas[8, 5] = 0; clas[8, 6] = 0; clas[8, 7] = 0; clas[8, 8] = 0; clas[8, 9] = 0; //Person9
            clas[9, 0] = 1; clas[9, 1] = 0; clas[9, 2] = 1; clas[9, 3] = 0; clas[9, 4] = 1; clas[9, 5] = 0; clas[9, 6] = 1; clas[9, 7] = 0; clas[9, 8] = 1; clas[9, 9] = 0; //Person10
            clas[10, 0] = 0; clas[10, 1] = 1; clas[10, 2] = 0; clas[10, 3] = 1; clas[10, 4] = 1; clas[10, 5] = 1; clas[10, 6] = 0; clas[10, 7] = 1; clas[10, 8] = 0; clas[10, 9] = 1; //Person11
            clas[11, 0] = 1; clas[11, 1] = 1; clas[11, 2] = 0; clas[11, 3] = 0; clas[11, 4] = 1; clas[11, 5] = 1; clas[11, 6] = 0; clas[11, 7] = 0; clas[11, 8] = 1; clas[11, 9] = 1; //Person12
            clas[12, 0] = 1; clas[12, 1] = 0; clas[12, 2] = 0; clas[12, 3] = 0; clas[12, 4] = 0; clas[12, 5] = 1; clas[12, 6] = 1; clas[12, 7] = 1; clas[12, 8] = 1; clas[12, 9] = 1; //Person13
            clas[13, 0] = 1; clas[13, 1] = 1; clas[13, 2] = 1; clas[13, 3] = 0; clas[13, 4] = 1; clas[13, 5] = 0; clas[13, 6] = 0; clas[13, 7] = 0; clas[13, 8] = 0; clas[13, 9] = 0; //Person14
            clas[14, 0] = 1; clas[14, 1] = 0; clas[14, 2] = 1; clas[14, 3] = 0; clas[14, 4] = 1; clas[14, 5] = 0; clas[14, 6] = 1; clas[14, 7] = 0; clas[14, 8] = 1; clas[14, 9] = 0; //Person15
            clas[15, 0] = 0; clas[15, 1] = 1; clas[15, 2] = 0; clas[15, 3] = 1; clas[15, 4] = 1; clas[15, 5] = 1; clas[15, 6] = 0; clas[15, 7] = 1; clas[15, 8] = 0; clas[15, 9] = 1; //Person16
            clas[16, 0] = 1; clas[16, 1] = 1; clas[16, 2] = 0; clas[16, 3] = 0; clas[16, 4] = 1; clas[16, 5] = 1; clas[16, 6] = 0; clas[16, 7] = 0; clas[16, 8] = 1; clas[16, 9] = 1; //Person17
            clas[17, 0] = 1; clas[17, 1] = 0; clas[17, 2] = 0; clas[17, 3] = 0; clas[17, 4] = 0; clas[17, 5] = 1; clas[17, 6] = 1; clas[17, 7] = 1; clas[17, 8] = 1; clas[17, 9] = 1; //Person18
            clas[18, 0] = 1; clas[18, 1] = 1; clas[18, 2] = 1; clas[18, 3] = 0; clas[18, 4] = 1; clas[18, 5] = 0; clas[18, 6] = 0; clas[18, 7] = 0; clas[18, 8] = 0; clas[18, 9] = 0; //Person19
            clas[19, 0] = 1; clas[19, 1] = 0; clas[19, 2] = 1; clas[19, 3] = 0; clas[19, 4] = 1; clas[19, 5] = 0; clas[19, 6] = 1; clas[19, 7] = 0; clas[19, 8] = 1; clas[19, 9] = 0; //Person20
            clas[20, 0] = 0; clas[20, 1] = 1; clas[20, 2] = 0; clas[20, 3] = 1; clas[20, 4] = 1; clas[20, 5] = 1; clas[20, 6] = 0; clas[20, 7] = 1; clas[20, 8] = 0; clas[20, 9] = 1; //Person21
            clas[21, 0] = 1; clas[21, 1] = 1; clas[21, 2] = 0; clas[21, 3] = 0; clas[21, 4] = 1; clas[21, 5] = 1; clas[21, 6] = 0; clas[21, 7] = 0; clas[21, 8] = 1; clas[21, 9] = 1; //Person22
            clas[22, 0] = 1; clas[22, 1] = 0; clas[22, 2] = 0; clas[22, 3] = 0; clas[22, 4] = 0; clas[22, 5] = 1; clas[22, 6] = 1; clas[22, 7] = 1; clas[22, 8] = 1; clas[22, 9] = 1; //Person23
            clas[23, 0] = 1; clas[23, 1] = 1; clas[23, 2] = 1; clas[23, 3] = 0; clas[23, 4] = 1; clas[23, 5] = 0; clas[23, 6] = 0; clas[23, 7] = 0; clas[23, 8] = 0; clas[23, 9] = 0; //Person24
            clas[24, 0] = 1; clas[24, 1] = 0; clas[24, 2] = 1; clas[24, 3] = 0; clas[24, 4] = 1; clas[24, 5] = 0; clas[24, 6] = 1; clas[24, 7] = 0; clas[24, 8] = 1; clas[24, 9] = 0; //Person25
            clas[25, 0] = 0; clas[25, 1] = 1; clas[25, 2] = 0; clas[25, 3] = 1; clas[25, 4] = 1; clas[25, 5] = 1; clas[25, 6] = 0; clas[25, 7] = 1; clas[25, 8] = 0; clas[25, 9] = 1; //Person26
            clas[26, 0] = 1; clas[26, 1] = 1; clas[26, 2] = 0; clas[26, 3] = 0; clas[26, 4] = 1; clas[26, 5] = 1; clas[26, 6] = 0; clas[26, 7] = 0; clas[26, 8] = 1; clas[26, 9] = 1; //Person27
            clas[27, 0] = 1; clas[27, 1] = 0; clas[27, 2] = 0; clas[27, 3] = 0; clas[27, 4] = 0; clas[27, 5] = 1; clas[27, 6] = 1; clas[27, 7] = 1; clas[27, 8] = 1; clas[27, 9] = 1; //Person28
            clas[28, 0] = 1; clas[28, 1] = 1; clas[28, 2] = 1; clas[28, 3] = 0; clas[28, 4] = 1; clas[28, 5] = 0; clas[28, 6] = 0; clas[28, 7] = 0; clas[28, 8] = 0; clas[28, 9] = 0; //Person29
            clas[29, 0] = 1; clas[29, 1] = 0; clas[29, 2] = 0; clas[29, 3] = 0; clas[29, 4] = 0; clas[29, 5] = 0; clas[29, 6] = 0; clas[29, 7] = 0; clas[29, 8] = 1; clas[29, 9] = 0; //Person30
            clas[30, 0] = 0; clas[30, 1] = 0; clas[30, 2] = 0; clas[30, 3] = 0; clas[30, 4] = 0; clas[30, 5] = 0; clas[30, 6] = 0; clas[30, 7] = 0; clas[30, 8] = 0; clas[30, 9] = 0; //Person 31
            int[] count = new int[31]; //no. of announcements by the person
            for (int c = 0; c < 30; c++) count[c] = 0;
            int[,] dutyAssignedTo = new int[10, 4]; //4 people for each slot on a day
            for (int i = 0; i < 10; i++)
            {
                for (int p = 0; p < 4; p++)
                    dutyAssignedTo[i, p] = -1;
            }
            int j, k, l, m;
            for (int i = 0; i < 10; i++) //for slot
            {
                for (j = 0; j < 31; j++) //for person
                {
                    if (clas[j, i] == 0 && count[j] < 1) //if student is free and has less than 1 announcement
                    {
                        dutyAssignedTo[i, 0] = j; //1st person to do the announcement in SJT selected
                        count[j]++;
                        for (k = j + 1; k < 31; k++) //searching for the next person to do announcement in the slot
                        {
                            if (clas[k, i] == 0 && count[k] < 1) //if student is free and has less than 1 announcement
                            {
                                dutyAssignedTo[i, 1] = k; //2nd person to do the announcement in SJT selected
                                count[k]++;
                                for (l = k + 1; l < 31; l++)
                                {
                                    if (clas[l, i] == 0 && count[l] < 1) //if student is free and has less than 1 announcement
                                    {
                                        dutyAssignedTo[i, 2] = l; //1st person to do the announcement in TT selected
                                        count[l]++;
                                        for (m = l + 1; m < 31; m++)
                                        {
                                            if (clas[m, i] == 0 && count[m] < 1) //if student is free and has less than 1 announcement
                                            {
                                                dutyAssignedTo[i, 3] = m; //2nd person to do the announcement in TT selected
                                                count[m]++;
                                                goto here;
                                            }
                                        }
                                        goto here;
                                    }
                                }
                                goto here;
                            }
                        }
                        goto here;
                    }
                }
            here: ;
            }
        }
    }
}
