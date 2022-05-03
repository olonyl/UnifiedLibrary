using NUnit.Framework;
using SingleLibrary;
using System;

namespace UnifiedLibrary.UnitTests
{
    class ImmutableStackTests
    {
        [Test]
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            var emptyStack = Stack<int>.Empty;

            Assert.IsTrue(emptyStack.IsEmpty);
        }

        [Test]
        public void Peek_EmptyStack_ThrowsException()
        {
            var emptyStack = Stack<int>.Empty;

            Assert.Throws<InvalidOperationException>(() => emptyStack.Peek());
            Assert.Throws<InvalidOperationException>(() => emptyStack.Pop());
        }

        [Test]
        public void PushOnEmptyStackTwoItems_PeekOneElement_ReturnsCorrectValue()
        {
            var stack = Stack<int>.Empty;
            stack = stack.Push(1);
            stack = stack.Push(2);

            int result = stack.Peek();
            Assert.AreEqual(result, 2);
        }

        [Test]
        public void PushOnEmptyStackOneElement_PopOneElement_ReturnsEmptyStack()
        {
            var stack = Stack<int>.Empty;
            stack = stack.Push(1);
            var result = stack.Pop();

            Assert.IsTrue(result.IsEmpty);
        }
    }
}