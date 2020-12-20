"""
Solution to project euler problem 16: Power digit sum.
"""


def sum_digits(num: int) -> int:
    """Return the sum of the digits in num.
    """
    num_as_str = str(num)
    sum_so_far = 0

    for char in num_as_str:
        sum_so_far += int(char)

    return sum_so_far


if __name__ == '__main__':
    power = 2 ** 1000
    print(sum_digits(power))
