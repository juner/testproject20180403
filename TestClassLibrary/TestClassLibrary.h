#pragma once

using namespace System;

namespace TestClassLibrary {
	public ref class Class1
	{
	private:
		int value;
	public:
		Class1() : value{ 1 } {
		}
		int GetValue() {
			return value;
		}

		~Class1() {
			this->!Class1();
		}
		!Class1() {
			value = 0;
		}
	};
}
