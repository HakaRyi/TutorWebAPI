using demoAPITutor.DTOs.Request;
using demoAPITutor.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace demoAPITutor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _userService;
        public AuthController(IAuthService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        [AllowAnonymous] // Cho phép truy cập mà không cần xác thực
        public async Task<IActionResult> Register([FromBody] SignUpRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); 
            }

            try
            {
                var newUser = await _userService.RegisterUserAsync(request);
                // Trả về 201 Created với thông tin người dùng mới
                return CreatedAtAction(nameof(GetUserById), new { id = newUser.Id }, newUser);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return StatusCode(500, new { message = ex.Message }); // Lỗi server
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Something occurs when you register" });
            }
        }
        // Endpoint này để cho hàm CreatedAtAction tham chiếu
        [HttpGet("{id}")]
        [Authorize] // Bảo vệ endpoint này, chỉ user đã đăng nhập mới xem được thông tin của user khác
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            // Bạn có thể thêm logic kiểm tra quyền ở đây, ví dụ: chỉ Admin hoặc chính user đó mới xem được
            return Ok(user);
        }
    }
}
