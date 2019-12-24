using System.Threading;

namespace ex1
{
    /// <summary>
    /// Cookie Store code with parallel constructs, to optimize and improve performance of cookie baking.
    /// </summary>
    public class CookieStoreExt
    {
        private object cookieDoughLock = new object();
        private object ovenLock = new object();
        private object packagingLock = new object();

        public HelloWorldCookie CreateHelloWorldCookie()
        {
            CookieDough cookieDough;
            Cookie cookie;
            HelloWorldCookie helloWorldCookie;
            lock (cookieDoughLock)
            {
                cookieDough = MixDough();
                SheetOrLaminateDough(cookieDough);
                FormDough(cookieDough);
            }

            lock (ovenLock)
            {
                cookie = BakeDough(cookieDough);
            }

            lock (packagingLock)
            {
                FillCookie(cookie);
                CoolCookie(cookie);
                FreezeCookie(cookie);
                helloWorldCookie = PackCookie(cookie);
            }
            return helloWorldCookie;
        }

        private CookieDough MixDough()
        {
            Utils.Process();
            return CookieDoughIngredients.Mix();
        }

        private CookieDough SheetOrLaminateDough(CookieDough cookieDough)
        {
            return cookieDough.SheetOrLaminate();
        }

        private CookieDough FormDough(CookieDough cookieDough)
        {
            return cookieDough.PlaceInForm();
        }

        private Cookie BakeDough(CookieDough cookieDough)
        {
            return cookieDough.Bake();
        }

        private Cookie FillCookie(Cookie cookie)
        {
            return cookie.Fill();
        }

        private Cookie CoolCookie(Cookie cookie)
        {
            return cookie.Cool();
        }

        private Cookie FreezeCookie(Cookie cookie)
        {
            return cookie.Freeze();
        }

        private HelloWorldCookie PackCookie(Cookie cookie)
        {
            return cookie.Pack();
        }

    }
}
