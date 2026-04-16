// ----------------------------------------------------------------
// 輔助類別：Ball (放在同一個檔案中，不加 public 以避免編譯器混淆，或保持 public 但確保檔名正確)
// ----------------------------------------------------------------
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;

    [Header("球體設定")]
    public float baseSpeed = 5f;
    public float maxSpeed = Mathf.Infinity;
    public float currentSpeed { get; set; }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        rb.velocity = Vector2.zero;
        rb.position = Vector2.zero;
    }

    public void AddStartingForce()
    {
        // 隨機決定左右方向
        float x = Random.value < 0.5f ? -1f : 1f;

        // 隨機決定上下方向，範圍設在 0.5 ~ 1.0 確保球不會只走水平線
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f)
                                      : Random.Range(0.5f, 1f);

        // 套用初始衝量
        Vector2 direction = new Vector2(x, y).normalized;
        rb.AddForce(direction * baseSpeed, ForceMode2D.Impulse);
        currentSpeed = baseSpeed;
    }

    private void FixedUpdate()
    {
        // 限制球的最高速度並維持目前的移動方向
        Vector2 direction = rb.velocity.normalized;

        // 如果球剛被 ResetPosition 或是靜止狀態，direction 會是 zero，需判斷避免報錯
        if (direction != Vector2.zero)
        {
            currentSpeed = Mathf.Min(currentSpeed, maxSpeed);
            rb.velocity = direction * currentSpeed;
        }
    }
}