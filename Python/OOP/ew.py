a = "xaxa"
b = 42

c = (a, b := b, a) if a else b
print(c)
