"""
Solution to project euler problem 14: Longest Collatz Sequence.
"""


def collatz(starting_num: int) -> int:
    """Return the collatz sequence length for this starting_num.
    """
    sequence_len = 1

    while starting_num != 1:
        if starting_num % 2 == 0:
            starting_num //= 2
        else:  # starting_num % 2 != 0
            starting_num = (3 * starting_num) + 1
        sequence_len += 1

    return sequence_len


if __name__ == '__main__':
    max_sequence = 1
    max_starting_num = 1
    for i in range(2, 1000001):
        if collatz(i) > max_sequence:
            max_sequence = collatz(i)
            max_starting_num = i

    print(max_starting_num)
