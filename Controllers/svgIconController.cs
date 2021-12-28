using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebConfigurationApi.Data;
using WebConfigurationApi.Models.EntityModel;

namespace WebConfigurationApi.Controllers
{
    [ApiController]
    [Route("/[controller]/[action]")]
    public class svgIconController : Controller
    {
        private readonly webConfigurationContext _context;

        public svgIconController(webConfigurationContext context)
        {
            _context = context;
        }
        #region 添加icon
        #endregion
        [HttpPost]
        public async Task<ResponseObject<SvgLibraryModel>> addSvgIcon(SvgLibraryModel Info)
        {
            ResponseObject<SvgLibraryModel> reInfo = new ResponseObject<SvgLibraryModel>();
            if (string.IsNullOrEmpty(Info.iconName) || string.IsNullOrEmpty(Info.svgPath))
            {
                reInfo.result = false;
                reInfo.msg = "内容为空不能提交";
                reInfo.code = 404;
                return reInfo;
            }
            else
            {
                var addinfo = new SvgLibraryModel()
                {
                    iconName = Info.iconName,
                    svgPath = Info.svgPath
                };
                _context.Add(addinfo);
                await _context.SaveChangesAsync();
                reInfo.result = true;
                reInfo.msg = "成功";
                reInfo.code = 200;
                return reInfo;
            }
        }
        #region 查询全部icon
        #endregion
        [HttpPost]
        public async Task<ResponseObject<SvgLibraryModel>> querySvgIconByAll()
        {
            ResponseObject<SvgLibraryModel> reInfo = new ResponseObject<SvgLibraryModel>();

            reInfo.result = true;
            reInfo.msg = "成功";
            reInfo.code = 200;
            reInfo.data = await _context.dbSvgLibrary.ToListAsync();
            return reInfo;
        } 

    }
}