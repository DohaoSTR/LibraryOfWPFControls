﻿using System.Windows;
using System.Windows.Controls;

namespace ZdfFlatUI
{
    public class TimeButton : ListBoxItem
    {
        #region Private属性
        #endregion

        #region 依赖属性定义

        #endregion

        #region 依赖属性set get

        #endregion

        #region Constructors
        static TimeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TimeButton), new FrameworkPropertyMetadata(typeof(TimeButton)));
        }
        #endregion

        #region Override方法
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }
        #endregion

        #region Private方法

        #endregion
    }
}
