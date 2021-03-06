﻿using LLM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace Sample
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            InitAnimList();
        }

        private List<CustomAnim> CustomAnims = new List<CustomAnim>();
        private IAnimation _anim;

        private void InitAnimList()
        {
            InitAnims();

            AnimList.ItemsSource = CustomAnims;
            
        }

        void InitAnims()
        {
            foreach(var animType in Enum.GetValues(typeof(AnimationType)))
            {
                AddAnim(Enum.GetName(typeof(AnimationType), animType), (AnimationType)animType);
            }
        }

        void AddAnim(string name, AnimationType type)
        {
            CustomAnims.Add(new CustomAnim()
            {
                Name = name,
                ClickAction = () => {
                    if (_anim != null)
                        _anim.Stop();
                    _anim = Animator.Use(type).PlayOn(AnimText);
                }
            });
        }

        private void AnimList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Reset();
            (e.ClickedItem as CustomAnim).ClickAction();
        }

        void Reset()
        {
            AnimText.Opacity = 1;
            AnimText.RenderTransform = null;
            AnimText.Projection = null;
        }
    }

    internal class CustomAnim
    {
        public string Name { get; set; }

        public Action ClickAction { get; set; }
    }
}
