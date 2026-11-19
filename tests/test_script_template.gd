extends GutTest

func test_example():
	# Example test case
	var result = 1 + 1
	assert_eq(result, 2, "1 + 1 should equal 2")

func test_message_exemple():
	# Example test case for message
	var message = "Hello, Godot!"
	assert_eq(message, "Hello, Godot!", "Message should be 'Hello, Godot!'")
