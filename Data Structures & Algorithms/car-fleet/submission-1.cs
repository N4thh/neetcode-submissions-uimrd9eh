

public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;

        // 1. Ghép vị trí và tốc độ
        var cars = new List<(int pos, int spd)>();
        for (int i = 0; i < n; i++)
            cars.Add((position[i], speed[i]));

        // 2. Sắp xếp theo vị trí giảm dần (gần đích trước)
        cars.Sort((a, b) => b.pos.CompareTo(a.pos));

        // 3. Stack lưu thời gian đến đích của các fleet
        Stack<double> stack = new Stack<double>();

        foreach (var car in cars) {
            double time = (double)(target - car.pos) / car.spd;

            // Nếu stack trống hoặc thời gian > đỉnh → tạo fleet mới
            if (stack.Count == 0 || time > stack.Peek()) {
                stack.Push(time);
            }
            // Nếu time <= stack.Peek() → nhập fleet trên đỉnh, không push
        }

        return stack.Count; // số lượng fleet
    }
}
