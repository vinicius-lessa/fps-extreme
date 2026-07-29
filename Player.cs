using Godot;
using System;

public partial class Player : CharacterBody3D
{
	public const float Speed = 5.0f;
	public const float JumpVelocity = 4.5f;
	[Export]
	public float MouseSens { get; set; } = 0.005f; 
	public Camera3D _camera;

	public override void _Ready()
	{
		// Trava e esconde o cursor do mouse no centro da tela (Essencial para FPS)
		Input.MouseMode = Input.MouseModeEnum.Captured;
		
		// Pega a referência do nó Camera3D (Ajuste o caminho se a câmera estiver em outro nível)
		_camera = GetNode<Camera3D>("Camera3D");
	}

	public override void _Input(InputEvent @event)
	{
		// Verifica se o evento de input é um movimento do mouse
		if (@event is InputEventMouseMotion mouseMotion)
		{
			// Rotação Horizontal (Yaw): Rotaciona o corpo inteiro do personagem (a cápsula)
			RotateY(-mouseMotion.Relative.X * MouseSens);

			// Rotação Vertical (Pitch): Rotaciona APENAS a cabeça/câmera
			_camera.RotateX(-mouseMotion.Relative.Y * MouseSens);

			// Trava do Pescoço (Clamp)
			// Em C#, não podemos modificar propriedades de um Vector3 diretamente dentro da Transform,
			// então extraímos a rotação, aplicamos o Clamp no eixo X e devolvemos o vetor inteiro.
			Vector3 cameraRot = _camera.Rotation;
			cameraRot.X = Mathf.Clamp(cameraRot.X, Mathf.DegToRad(-50f), Mathf.DegToRad(80f));
			_camera.Rotation = cameraRot;
		}
	}

	public override void _PhysicsProcess(double delta)
	{
		Vector3 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
		{
			velocity += GetGravity() * (float)delta;
		}

		// Handle Jump.
		if (Input.IsActionJustPressed("ui_accept") && IsOnFloor())
		{
			velocity.Y = JumpVelocity;
		}

		if (Input.IsActionJustPressed("quit"))
		{
			Input.MouseMode = Input.MouseModeEnum.Visible;
			GetTree().Quit();
		}

		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 inputDir = Input.GetVector("notright", "right", "forward", "backward");
		Vector3 direction = (Transform.Basis * new Vector3(inputDir.X, 0, inputDir.Y)).Normalized();
		if (direction != Vector3.Zero)
		{
			velocity.X = direction.X * Speed;
			velocity.Z = direction.Z * Speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
			velocity.Z = Mathf.MoveToward(Velocity.Z, 0, Speed);
		}

		Velocity = velocity;
		MoveAndSlide();
	}
}
