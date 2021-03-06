﻿using TestStack.Seleno.PageObjects;

namespace MvcMusicStore.FunctionalTests.Step2.Pages
{
    public class HomePage : Page
    {
        public NavigationComponent Menu
        {
            get { return GetComponent<NavigationComponent>(); }
        }

        public GenreNavigationComponent GenreMenu
        {
            get { return GetComponent<GenreNavigationComponent>(); }
        }
    }
}
