﻿using System;

namespace Narumikazuchi.Windows
{
    /// <summary>
    /// Contains the <typeparamref name="TTheme"/> after a change occured at the <see cref="ThemeManager{TTheme}"/>.
    /// </summary>
    public sealed class ThemeChangedEventArgs<TTheme> : EventArgs where TTheme : struct, IEquatable<TTheme>, ITheme
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeChangedEventArgs{TTheme}"/> class.
        /// </summary>
        public ThemeChangedEventArgs(TTheme theme) => this.NewTheme = theme;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the <see cref="ThemeChangedEventArgs{TTheme}"/> for the current theme.
        /// </summary>
        public static ThemeChangedEventArgs<TTheme> Current => new(ISingleton<ThemeManager<TTheme>>.Instance.SelectedTheme);

        /// <summary>
        /// Gets the new <see cref="ThemeManager{TTheme}.SelectedTheme"/>.
        /// </summary>
        public TTheme NewTheme { get; }

        #endregion
    }
}
