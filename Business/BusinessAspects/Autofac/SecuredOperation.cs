using Business.Constants;
using Castle.DynamicProxy;
using Core.Extensions;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Business.BusinessAspects.Autofac
{
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor; //jwt istek yapılıyor aynı anda birden fazl akişi istek yaptığında herkes için ayrı bir httpcontext oluşur

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(','); //metni sbelirlenen karaktere göre ayırıp array e atar örneğin ("product.add,admin")
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }

        protected override void OnBefore(IInvocation invocation)//onbefore yapıyoruz çünkü kullanıcının ytekisi var mı diye bakmak için
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles)//ilgili rol varsa döndürmeye devam et yoksa eğer o zaman bir hata vere
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}
